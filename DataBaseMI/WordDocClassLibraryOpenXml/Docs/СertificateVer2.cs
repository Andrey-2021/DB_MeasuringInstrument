using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordDocDTO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordDocClassLibraryOpenXml.Docs
{
    internal class СertificateVer2
    {
        СertificateDTO _dTO;
        public СertificateVer2(СertificateDTO dTO)
        {
            this._dTO = dTO;
        }

        public void CreateСertificateV2()
        {
            try
            {
                using (WordprocessingDocument package
                    = WordprocessingDocument.Create(_dTO.FileName, WordprocessingDocumentType.Document))
                {

                    DocExtension.CreateMainPart(package);
                    Body body = package.MainDocumentPart.Document.Body;

                    var head = TabExtension2.InsertTable(2, 1);
                    TabExtension2.DelCellBorder(head, 0, 0);
                    TabExtension2.DelCellBorder(head, 1, 0, false);
                    TabExtension2.ChangeText(head, 0, 0, _dTO?.Сertificate?.Businessman);
                    TabExtension2.ChangeText(head, 1, 0, "наименование юридического лица или индивидуального предпринимателя," +
                        " аккредитованного в установленном порядке на проведение поверки средств измерений, регистрационный номер аттестата аккредитации");
                    body.Append(head);

                    //Добавим параграф
                    //body.AppendChild(CommonDocumentParts.CreateEnumPargraph());

                    //шапка документа
                    Paragraph p = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("СВИДЕТЕЛЬСТВО О ПОВРКЕ №" + _dTO?.Сertificate?.Number);
                    p.Append(r);
                    body.AppendChild(p);

                    //Добавим параграф
                    Paragraph p2 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r2 = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("Действительно до");
                    p2.Append(r2);
                    body.AppendChild(p2);

                    //Добавим параграф
                    Paragraph p3 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r3 = RunExtension.CreateRun().RunBold().RunUnderline().RunFont("Times New Roman").RunSize(13).RunAddText(_dTO?.Сertificate?.ActiveDate.ToLongDateString());
                    p3.Append(r3);
                    body.AppendChild(p3);


                    //таблица
                    int n = 0;
                    var t = TabExtension2.InsertTable(14, 2, new int[] { 30, 70 });
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "Эталон (средство измерений)");
                    TabExtension2.DelCellBorder(t, n, 1);
                    TabExtension2.ChangeText(t, n, 1, _dTO.Сertificate.MeasuringInstrument.DeviceName
                                                + ", " + _dTO.Сertificate.MeasuringInstrument.DeviceType.TypeName);
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.DelCellBorder(t, n, 1, false);
                    TabExtension2.ChangeText(t, n, 1, "наименование, тип");

                    n++;
                    TabExtension2.HorizontolCellsMerge(t, n, 0, 2);
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.DelCellBorder(t, n, 1);
                    TabExtension2.ChangeText(t, n, 0, _dTO.Сertificate.Info);
                    n++;
                    TabExtension2.HorizontolCellsMerge(t, n, 0, 2);
                    TabExtension2.DelCellBorder(t, n, 0, false);
                    TabExtension2.DelCellBorder(t, n, 1, false);
                    TabExtension2.ChangeText(t, n, 0, "модификация, регистрационный номер в Федеральном информационном фонде " +
                        "по обеспечению единства измерений " +
                        "(если в состав эталона входят несколько автономных измерительных блоков, то приводят их перечень и заводские номера) " +
                        "серия и номер знака предыдущей поверки (если такие серия и номер имеются)");
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "Заводской номер (номера)");
                    TabExtension2.DelCellBorder(t, n, 1, true, false);
                    TabExtension2.ChangeText(t, n, 1, _dTO.Сertificate.MeasuringInstrument.ManufacturerNumber);
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "поверено");
                    TabExtension2.DelCellBorder(t, n, 1, true, false);
                    TabExtension2.ChangeText(t, n, 1, _dTO?.Сertificate?.Values);
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.DelCellBorder(t, n, 1);
                    TabExtension2.ChangeText(t, n, 1, "наименование величин, диапазонов, на которых поверен эталон (средство измерений) (если предусмотрено методикой поверки)");
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "Поверено в соответствии с");
                    TabExtension2.DelCellBorder(t, n, 1, true, false);
                    TabExtension2.ChangeText(t, n, 1, _dTO.Сertificate.Document);
                    n++;
                    TabExtension2.HorizontolCellsMerge(t, n, 0, 2);
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.DelCellBorder(t, n, 1);
                    TabExtension2.ChangeText(t, n, 1, "наименование документа, на основании которого выполнена поверка");
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "с применением эталонов единиц величин:");
                    TabExtension2.DelCellBorder(t, n, 1, true, false);
                    TabExtension2.ChangeText(t, n, 1, _dTO.Сertificate.Standard);
                    n++;
                    //TabExt2.HorizontolCellsMerge(t, n, 0, 2);
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.DelCellBorder(t, n, 1, false);
                    TabExtension2.ChangeText(t, n, 1, "наименование, тип, заводской номер, регистрационный номер (при наличии), разряд, " +
                        "класс или погрешность эталона, применяемого при проверке");
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "при следующих влияющих факторов:");
                    TabExtension2.DelCellBorder(t, n, 1, true, false);
                    TabExtension2.ChangeText(t, n, 1, _dTO.Сertificate.Factors);
                    n++;
                    TabExtension2.HorizontolCellsMerge(t, n, 0, 2);
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.DelCellBorder(t, n, 1, false);
                    TabExtension2.ChangeText(t, n, 0, "приводят перечень влияющих факторов, нормированных в документе на методику поверки, с указанием их значений" +
                        " и на основании результатов первичной (периодической) поверки признано (признан) " +
                        "соответствующим установленным в описании типа метрологическим требованиям " +
                        "и пригодным к применению в сфере государственного регулирования " +
                        "обеспечения единства измерений");
                    n++;
                    TabExtension2.DelCellBorder(t, n, 0);
                    TabExtension2.ChangeText(t, n, 0, "Знак поверки");
                    TabExtension2.DelCellBorder(t, n, 1, true, false);
                    TabExtension2.ChangeText(t, n, 1, _dTO.Сertificate.Mark);
                    body.Append(t);

                    //Добавим параграф
                    Paragraph p17 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run r17 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(14).RunAddText("");
                    p17.Append(r17);
                    r17.AppendChild(new Break());
                    body.AppendChild(p17);

                    //таблица с подписями
                    body.Append(CommonDocumentParts.CreateSignatureTable(_dTO.Сertificate?.Job,
                                                                        _dTO.Сertificate?.Director,
                                                                        _dTO.Сertificate?.WhatSeeInsteadCalibrator));

                    //Добавим параграф
                    body.AppendChild(CommonDocumentParts.CreateEnumPargraph());

                    //Добавим параграф
                    Paragraph pDate = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run rDate = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(14).RunAddText("Дата поверки");
                    pDate.Append(rDate);
                    body.AppendChild(pDate);

                    //Добавим параграф
                    Paragraph p20 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run r20 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(14)
                        .RunAddText(Environment.NewLine + _dTO?.Сertificate?.Date.ToLongDateString());
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
