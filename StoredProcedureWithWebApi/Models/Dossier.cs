using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcedureWithWebApi.Models
{
  public class Dossier
  {
    public Int64 id_Dossier { get; set; }

    public byte id_DossierState { get; set; }

    public byte id_DossierType { get; set; }

    public byte id_DossierCategory { get; set; }

    public Int64 DossierNumber { get; set; }

    public string RepetitionNumber { get; set; }

    public string OrderReference { get; set; }

    public string FirmNamefacture { get; set; }

    public string FirmNamegestion { get; set; }

    public string FirmNameclient { get; set; }

    public string FirmNamesousclient { get; set; }

    public string DossierName { get; set; }


    public string RepetitionProcessingDateTime { get; set; }

    public string UserName { get; set; }

    public DateTime OpeningDateTime { get; set; }

    public string Description { get; set; }

    public string Descriptionetatfacture { get; set; }

    public string InvoiceReference { get; set; }

    public string Descriptiontypedossier { get; set; }

    public string Descriptioncategoriedossier { get; set; }

    public string Edition { get; set; }

    public string ObsoleteDossier { get; set; }

  }
}