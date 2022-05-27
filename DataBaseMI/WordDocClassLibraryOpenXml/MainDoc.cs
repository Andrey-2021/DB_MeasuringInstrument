using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordDocClassLibraryOpenXml.Docs;
using WordDocDTO;

namespace WordDocClassLibraryOpenXml
{
    /// <summary>
    /// Создание документов .docx
    /// </summary>
    public class MainDoc
    {
        /// <summary>
        /// Создать Паспорт СИ
        /// </summary>
        /// <param name="dTO">Объект передачи данных для создания Паспорта СИ</param>
        /// <exception cref="NullReferenceException">dTO=null</exception>
        public static void CreatePasport(PasportDTO dTO)
        {
            if (dTO == null) throw new NullReferenceException(" Null объект " +nameof(PasportDTO) );
            
            switch (dTO.Ver)
            {
                case EnumPasportVersion.ver1:
                    PasportVer1 pasport1 = new PasportVer1();
                    pasport1.CreatePasportV1(dTO);
                    break;
                case EnumPasportVersion.ver2:
                    PasportVer2 pasport2 = new PasportVer2();
                    pasport2.CreatePasportV2(dTO);
                    break;
                default:
                    throw new ArgumentException("Необрабатываемое (неизвестное) значение " + nameof(EnumPasportVersion) + ": " + dTO.Ver);
                    //break;
            }

        }

        //Извещения о непригодности
        public static void CreateUnsuitability(UnsuitabilityDTO dTO)
        {
            if (dTO == null) throw new NullReferenceException(" Null объект " + nameof(UnsuitabilityDTO));

            UnsuitabilityDocument unsuitabilityDocument = new UnsuitabilityDocument(dTO);
            unsuitabilityDocument.CreateUnsuitabilityDoc();
        }

        //Свидетельства о поверке
        public static void CreateСertificate(СertificateDTO dTO)
        {
            if (dTO == null) throw new NullReferenceException(" Null объект " + nameof(PasportDTO));

            switch (dTO.Ver)
            {
                case EnumСertificateVersion.ver1:
                    СertificateVer1 certificate1 = new СertificateVer1(dTO);
                    certificate1.CreateСertificateV1();
                    break;
                case EnumСertificateVersion.ver2:
                    СertificateVer2 certificate2= new СertificateVer2(dTO);
                    certificate2.CreateСertificateV2();
                    break;
                default:
                    throw new ArgumentException("Необрабатываемое (неизвестное) значение " + nameof(EnumPasportVersion) + ": " + dTO.Ver);
                    //break;
            }
        }

        //Накладные на перемещения
        public static void CreateMovement(MovementDTO dTO)
        {
            if (dTO == null) throw new NullReferenceException(" Null объект " + nameof(MovementDTO));
            MovementDocument movementDocument = new MovementDocument(dTO);
            movementDocument.CreateMovmentDoc();
        }
        
        //Отчёты
        public static void CreateReports(ReportDTO dTo)
        {
            if (dTo == null) throw new NullReferenceException(" Null объект " + nameof(MovementDTO));
            ReportDocument document = new ReportDocument(dTo);
            document.CreateMovmentDoc();
        }
    }
}
