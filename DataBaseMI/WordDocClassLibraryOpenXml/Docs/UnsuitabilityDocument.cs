
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordDocClassLibraryOpenXml.Docs;
using WordDocDTO;

namespace WordDocClassLibraryOpenXml
{

    /// <summary>
    /// Извещение о непригодности к применению
    /// </summary>
    public class UnsuitabilityDocument
    {
        UnsuitabilityDTO _dTO;

        public UnsuitabilityDocument(UnsuitabilityDTO dTO)
        {
            this._dTO = dTO;
        }

        public void CreateUnsuitabilityDoc()
        {
            try
            {
                using (WordprocessingDocument package
                      = WordprocessingDocument.Create(_dTO.FileName, WordprocessingDocumentType.Document))
                {

                    DocExtension.CreateMainPart(package);
                    Body body = package.MainDocumentPart.Document.Body;

                    //шапка документа
                    Paragraph p = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("ИЗВЕЩЕНИЕ");
                    p.Append(r);
                    body.AppendChild(p);

                    //Бобавим параграф
                    Paragraph p2 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r2 = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("о непригодности к применению");
                    p2.Append(r2);
                    body.AppendChild(p2);

                    //Бобавим параграф
                    Paragraph p3 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r3 = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("№ " + _dTO?.Unsuitability?.Number);
                    p3.Append(r3);
                    body.AppendChild(p3);




                    var t = TabExtension2.InsertTable(9, 2, new int[] { 30, 70});
                    TabExtension2.DelCellBorder(t, 0, 0);
                    TabExtension2.DelCellBorder(t, 1, 0);
                    TabExtension2.ChangeText(t, 0, 0, "Средство измерений (эталон)");
                    TabExtension2.DelCellBorder(t, 0, 1);
                    TabExtension2.ChangeText(t, 0, 1, _dTO.Unsuitability.MeasuringInstrument.DeviceName
                                                + ", " + _dTO.Unsuitability.MeasuringInstrument.DeviceType.TypeName);
                    TabExtension2.DelCellBorder(t, 1, 1, false);
                    TabExtension2.ChangeText(t, 1, 1, "наименование, тип");
                    
                    TabExtension2.HorizontolCellsMerge(t, 2, 0, 2);
                    TabExtension2.DelCellBorder(t, 2, 0);
                    TabExtension2.DelCellBorder(t, 2, 1);
                    TabExtension2.ChangeText(t, 2, 0, _dTO.Unsuitability.Info);
                    TabExtension2.HorizontolCellsMerge(t, 3, 0, 2);
                    TabExtension2.DelCellBorder(t, 3, 0,false);
                    TabExtension2.DelCellBorder(t, 3, 1, false);
                    TabExtension2.ChangeText(t, 3, 0, "модификация, регистрационный номер в Федеральном информационном фонде по обеспечению единства измерений, " +
                        "серия и номер клейма предыдущей поверки (если такие серия и номер имеются)");
                    TabExtension2.HorizontolCellsMerge(t, 4, 0, 2);
                    TabExtension2.DelCellBorder(t, 4, 0);
                    TabExtension2.DelCellBorder(t, 4, 1);
                    //TabExt2.ChangeText(t, 4, 0, "серия и номер клейма предыдущей поверки (если такие серия и номер имеются)");

                    TabExtension2.DelCellBorder(t, 5, 0);
                    TabExtension2.ChangeText(t, 5, 0, "Заводской номер");
                    TabExtension2.DelCellBorder(t, 5, 1, true, false);
                    TabExtension2.ChangeText(t, 5, 1, _dTO.Unsuitability.MeasuringInstrument.ManufacturerNumber);

                    TabExtension2.DelCellBorder(t, 6, 0);
                    TabExtension2.ChangeText(t, 6, 0, "Поверено в соответствии с");
                    TabExtension2.DelCellBorder(t, 6, 1, true, false);
                    TabExtension2.ChangeText(t, 6, 1, _dTO.Unsuitability.Document);
                    TabExtension2.HorizontolCellsMerge(t, 7, 0, 2);
                    TabExtension2.DelCellBorder(t, 7, 0);
                    TabExtension2.DelCellBorder(t, 7, 1);
                    TabExtension2.ChangeText(t, 7, 0, "(наименование документа, на основании которого выполнена поверка)" +
                        " и на основании результатов первичной (периодической) поверки признано (признан) " +
                        "не соответствующим установленным в описании типа метрологическим требованиям " +
                        "и непригодным к применению в сфере государственного регулирования " +
                        "обеспечения единства измерений");

                    TabExtension2.DelCellBorder(t, 8, 0);
                    TabExtension2.ChangeText(t, 8, 0, "Причины непригодности");
                    TabExtension2.DelCellBorder(t, 8, 1, true, false);
                    TabExtension2.ChangeText(t, 8, 1, _dTO.Unsuitability.UnsuitabilityReasons);

                    body.Append(t);


                    //Добавим параграф
                    body.AppendChild(CommonDocumentParts.CreateEnumPargraph(1));

                    //Добавим параграф
                    Paragraph p18 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run r18 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Клеймо");
                    r18.AppendChild(new Break());
                    p18.Append(r18);
                    body.AppendChild(p18);

                    

                    body.Append(CommonDocumentParts.CreateSignatureTable(_dTO.Unsuitability.Job,
                                                                    _dTO.Unsuitability.Director,    
                                                                    _dTO.Unsuitability?.WhatSeeInsteadCalibrator));

                    //Добавим параграф
                    body.AppendChild(CommonDocumentParts.CreateEnumPargraph());

                    //Добавим параграф
                    Paragraph p20 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run r20 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(14)
                        .RunAddText(Environment.NewLine + _dTO?.Unsuitability?.Date.ToLongDateString());
                    p20.Append(r20);
                    body.AppendChild(p20);

                    package.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("При создании документа возникла ошибка: " + ex.Message);
            }
        }
    }
}
