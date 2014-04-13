using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visio = Microsoft.Office.Interop.Visio;


namespace pmt
{
    class Visualizer
    {
        public Visualizer()
        {
            // No initialization is required
        }

        // TODO:
        // 1. Вычислять макс.длину строки и делать размер Контейнера соответствующим
        //
        public static Program.ExitCode VisualizeUsers(Visio.Page targetPage,
                                                    rbacLINQ2SQLDataContext db)
        {
            Visio.Application visioApplication = null;
            Visio.Document stencilUML = null;
            Visio.Shape shapeUser = null;
            Visio.Shape shapeUserContainer = null;
            int lastElemInContainer = 0;
            Visio.Document targetDocument = null;
            Visio.ContainerProperties containerProperties = null;
            int currentDiagramServices = -1;
            int prevDiagramServices;
            System.Array containerMembers = null;


            if (targetPage == null)
            {
                return Program.ExitCode.Error;
            }

            try
            {
                // Turn on all Visio diagram services
                targetDocument = targetPage.Document;
                visioApplication = targetPage.Application;
                stencilUML = visioApplication.Documents.
                            OpenEx(@"C:\MyTestProjects\MCD\diploma\pmtool\pmt\pmt\UML_Class.vssx",
                                    (short)Visio.VisOpenSaveArgs.visOpenHidden);

                // Enable All Diagram Services to enable adding huge-named members to the container
                prevDiagramServices = targetDocument.DiagramServicesEnabled;
                targetDocument.DiagramServicesEnabled = currentDiagramServices;

                // DO NOT REMOVE NEXT LINE!
                //-- WTF?! Добавление этой строчки убирает из Container'а дефолтные члены.
                //-- Причем только для первого раза. Если создавать еще сущности, то уже будет опять с дефолтными.
                //
                //-- Вместо этой строки сейчас просто удаляются дефолтные члены контейнеров.
                //-- Благо, их генерится всего два, и удаление не занимает много времени.
                //targetPage.Document.OpenStencilWindow();

                // Just drop elements from User Table:
                //foreach (User u in db.User)
                //{
                //    System.Diagnostics.Debug.WriteLine(lastElemInContainer);
                //    shapeUser = targetPage.Drop(stencilUML.Masters["Member"], 0, 0);
                //    shapeUser.Text = String.Format("name: {0}|password: {1}|policy: {2}", u.Name, u.Password, u.Policy_Id);
                //    //shapeUser.Text = String.Format("name: {0}", u.Name);
                //    targetPage.Application.ActiveWindow.Select(shapeUser, (short)Visio.VisSelectArgs.visSelect);
                //}

                // Drop a container
                shapeUserContainer = targetPage.DropContainer(stencilUML.Masters["Class"], null);
                // Same as prev.row:
                //shapeUserContainer = targetPage.Drop(stencilUML.Masters["Class"], 5, 5);
                shapeUserContainer.Text = "User Table";

                // Get/Set Container List Spacing Interval (gap between members in list)
                //shapeUserContainer.ContainerProperties.SetListSpacing(Visio.VisUnitCodes.visInches, 0.2);
                //System.Diagnostics.Debug.WriteLine(shapeUserContainer.ContainerProperties.GetListSpacing(Visio.VisUnitCodes.visInches));
                
                // Delete default members, that appear right after a container was dropped on a page
                foreach (int o in shapeUserContainer.ContainerProperties.GetMemberShapes((int)Visio.VisContainerFlags.visContainerFlagsDefault))
                {
                    targetPage.Shapes.get_ItemFromID(o).Delete();
                }

                // Drop elements to the container
                lastElemInContainer = shapeUserContainer.ContainerProperties.GetListMembers().Length+1;
                foreach (User u in db.User)
                {
                    System.Diagnostics.Debug.WriteLine(lastElemInContainer);
                    if (lastElemInContainer != 1)
                    {
                        shapeUser = targetPage.DropIntoList(stencilUML.Masters["Separator"],
                                                            shapeUserContainer,
                                                            lastElemInContainer);
                        lastElemInContainer += 1;
                    }
                    shapeUser = targetPage.DropIntoList(stencilUML.Masters["Member"],
                                                            shapeUserContainer,
                                                            lastElemInContainer);
                    lastElemInContainer += 1;
                    shapeUser.Text = String.Format("name: {0}|password: {1}|policy: {2}", u.Name, u.Password, u.Policy_Id);

                    // Same with Insert method:
                    //shapeUserContainer.ContainerProperties.InsertListMember(
                    //    shapeUser = targetPage.Drop(stencilUML.Masters.get_ItemU("Member"),0,0), lastElemInContainer);
                    //shapeUser.Text = String.Format("Name: {0}|Password: {1}|Policy: {2}", u.Name, u.Password, u.Policy_Id);
                    //lastElemInContainer += 1;
                }

                containerProperties = shapeUserContainer.ContainerProperties;
                // Report on contents of container
                containerMembers = containerProperties.GetMemberShapes((int)Visio.VisContainerFlags.visContainerFlagsDefault);
                foreach (int member in containerMembers)
                {
                    System.Diagnostics.Debug.WriteLine(targetPage.Shapes.get_ItemFromID(member).NameU +
                        " |===> "+ targetPage.Shapes.get_ItemFromID(member).Text);
                }
                targetDocument.DiagramServicesEnabled = prevDiagramServices;
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
                // Return the Diagram Services status to its previous state if it was set in 
                // the try block. 
                if (currentDiagramServices != -1 && targetDocument != null)
                {
                    targetDocument.DiagramServicesEnabled = currentDiagramServices;
                }
                throw;
            }

            targetPage.Application.ActiveWindow.DeselectAll();
            targetPage.CenterDrawing();
            stencilUML.Close();
            return Program.ExitCode.Success;
        }

        public static bool ClearPage(Visio.Page targetPage)
        {
            try
            {
                Visio.Selection selection;
                targetPage.Application.ActiveWindow.SelectAll();
                selection = targetPage.Application.ActiveWindow.Selection;
                selection.Delete();
                
                // Не все удаляет.
                //foreach (Visio.Shape sh in targetPage.Shapes)
                //{
                //    sh.DeleteEx(0);
                //}
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool DeletePage(Visio.Page targetPage)
        {
            try
            {
                targetPage.Delete(1);
            }
            catch
            {
                return false;
            }
            return true;
        }


        ///// <summary>This method looks for the document with the name specified
        ///// in stencilName in the Documents collection and, if the document is
        ///// not in the collection, opens it as a docked stencil. It then gets
        ///// the master, using its universal name masterNameU, and drops it on
        ///// the specified page.</summary>
        ///// <param name="pageToDrop">Page where the master will be dropped
        ///// </param>
        ///// <param name="masterNameU">Universal name of the master in the
        ///// stencil</param>
        ///// <param name="stencilName">Name of the stencil from which the master
        ///// is to be found</param>
        ///// <param name="pinX">X-coordinate of the pin in the specified units
        ///// </param>
        ///// <param name="pinY">Y-coordinate of the pin in the specified units
        ///// </param>
        ///// <param name="units">Units used by pinX and pinY</param>
        ///// <returns>Shape that was created by dropping the master on the page
        ///// indicated by the page parameter</returns>
        //private Visio.Shape DropMasterOnPage(Visio.Page pageToDrop,
        //                                    string masterNameU,
        //                                    string masterText,
        //                                    string stencilName,
        //                                    int pinX,
        //                                    int pinY,
        //                                    object units)
        //{

        //    if (pageToDrop == null || masterNameU == null
        //        || stencilName == null)
        //    {
        //        return null;
        //    }

        //    Visio.Application visioApplication;
        //    Visio.Documents visioDocuments;
        //    Visio.Document stencil;
        //    Visio.Master masterInStencil;
        //    Visio.Shape droppedShape = null;
        //    Visio.Cell cellPinX; Visio.Cell cellPinY;
        //    double pinXInternal; double pinYInternal;

        //    visioApplication = (Visio.Application)pageToDrop.Application;

        //    try
        //    {
        //        // Verify that all incoming string parameters are not of zero 
        //        // length, except for the ones that have default values as ""
        //        // and the output parameters.
        //        if (masterNameU.Length == 0)
        //            throw new System.ArgumentNullException("masterNameU", "Zero length string input.");
        //        if (stencilName.Length == 0)
        //            throw new System.ArgumentNullException("stencilName", "Zero length string input.");

        //        // Find the stencil in the Documents collection by name.
        //        visioDocuments = visioApplication.Documents;

        //        try
        //        {
        //            stencil = visioDocuments[stencilName];
        //        }
        //        catch (System.Runtime.InteropServices.COMException)
        //        {
        //            // The stencil is not in the collection; open it as a 
        //            // docked stencil.
        //            stencil = visioDocuments.OpenEx(stencilName, (short)Visio.VisOpenSaveArgs.visOpenDocked);
        //        }

        //        // Get a master from the stencil by its universal name.
        //        masterInStencil = stencil.Masters.get_ItemU(masterNameU);

        //        // Convert the PinX and PinY into internal units.
        //        pinXInternal = visioApplication.ConvertResult(pinX, units, Visio.VisUnitCodes.visInches);
        //        pinYInternal = visioApplication.ConvertResult(pinY, units, Visio.VisUnitCodes.visInches);

        //        // Drop the master on the page that is passed in.
        //        // Set the PinX and PinY using pinXInternal and
        //        // pinYInternal respectively.
        //        droppedShape = pageToDrop.Drop(masterInStencil, pinXInternal, pinYInternal);

        //        droppedShape.Text = masterText;

        //        // Update the units for PinX and PinY of the shape.
        //        cellPinX = droppedShape.get_CellsSRC((short)Visio.VisSectionIndices.visSectionObject,
        //                                            (short)Visio.VisRowIndices.visRowXFormOut,
        //                                            (short)Visio.VisCellIndices.visXFormPinX);
        //        cellPinY = droppedShape.get_CellsSRC((short)Visio.VisSectionIndices.visSectionObject,
        //                                            (short)Visio.VisRowIndices.visRowXFormOut,
        //                                            (short)Visio.VisCellIndices.visXFormPinY);
        //        cellPinX.set_Result(units, pinX);
        //        cellPinY.set_Result(units, pinY);
        //    }
        //    catch (System.Runtime.InteropServices.COMException err)
        //    {
        //        System.Diagnostics.Debug.WriteLine(err.Message);
        //    }

        //    return droppedShape;
        //}
    }
}
