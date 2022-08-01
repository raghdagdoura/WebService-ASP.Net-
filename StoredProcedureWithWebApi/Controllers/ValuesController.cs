using StoredProcedureWithWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace StoredProcedureWithWebApi.Controllers
{
  public class ValuesController : ApiController
  {
    // Chaine de connexion
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapi_conn"].ConnectionString);

    Dossier Doss = new Dossier();
   
    // GET api/values
    public List<Dossier> Get()
    {
      SqlDataAdapter da = new SqlDataAdapter("SPDossier_SelectAll7", con);
      da.SelectCommand.CommandType = CommandType.StoredProcedure;
      DataTable dt = new DataTable();
      da.Fill(dt);
      List<Dossier> listdossier = new List<Dossier>();
      if(dt.Rows.Count > 0)
      {
        for(int i=0; i< dt.Rows.Count; i++)
        {
          Dossier Doss = new Dossier();
          Doss.id_Dossier = Convert.ToInt32(dt.Rows[i]["id_dossier"]);
          Doss.id_DossierType = (byte)Convert.ToInt32(dt.Rows[i]["id_DossierType"]);
          Doss.id_DossierCategory = (byte)Convert.ToInt32(dt.Rows[i]["id_DossierCategory"]);
          Doss.id_DossierState = (byte)Convert.ToInt32(dt.Rows[i]["id_DossierState"]);
          Doss.DossierNumber = Convert.ToInt32(dt.Rows[i]["N° Dossier"]);
          Doss.RepetitionNumber = dt.Rows[i]["N° répétition"].ToString();
          Doss.OrderReference = dt.Rows[i]["Réf. Commande"].ToString();
          Doss.FirmNamefacture = dt.Rows[i]["Facturation"].ToString();
          Doss.FirmNamegestion = dt.Rows[i]["Gestion"].ToString();
          Doss.FirmNameclient = dt.Rows[i]["Client"].ToString();
          Doss.FirmNamesousclient = dt.Rows[i]["Sous Client"].ToString();
          Doss.DossierName = dt.Rows[i]["Nom du dossier"].ToString();
          Doss.RepetitionProcessingDateTime = dt.Rows[i]["Date traitement"].ToString();
          Doss.UserName = dt.Rows[i]["chef de fabrication"].ToString();
          Doss.OpeningDateTime = Convert.ToDateTime(dt.Rows[i]["date ouverture"]);
          Doss.Description = dt.Rows[i]["Etat"].ToString();
          Doss.Descriptionetatfacture = dt.Rows[i]["Etat de facturation"].ToString();
          Doss.InvoiceReference = dt.Rows[i]["N° facture"].ToString();
          Doss.Descriptiontypedossier = dt.Rows[i]["Type dossier"].ToString();
          Doss.Descriptioncategoriedossier = dt.Rows[i]["Catégorie du dossier"].ToString();
          Doss.Edition = dt.Rows[i]["Gestion lots"].ToString();
          Doss.ObsoleteDossier = dt.Rows[i]["Obsolète"].ToString();
          listdossier.Add(Doss);
        }
      }
      if (listdossier.Count > 0)
      {
        return listdossier;
      }
      else
      {
        return null;

      }

    }


    // GET api/values/5
    //public Dossier Get(int id)
    //{
     
    //}

    // POST api/values
    public void Post(Dossier dossier)
    {
      //string msg = "";
      //if (dossier != null)
      //{
      //  SqlCommand cmd = new SqlCommand("SPDossier_SelectAll7", con);
      //  cmd.CommandType = CommandType.StoredProcedure;
      //  SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);

      //  con.Open();
      //  int i = cmd.ExecuteNonQuery();
      //  con.Close();

      //  if (i > 0)
      //  {
      //    msg = "les données ont été insérées";
      //  }
      //  else
      //  {
      //    msg = "error";
      //  }
      //}
      //return msg;
    }

    // PUT api/values/5
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }
  }
}
