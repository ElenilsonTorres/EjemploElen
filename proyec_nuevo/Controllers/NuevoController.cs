using proyec_nuevo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyec_nuevo.Controllers
{
    public class NuevoController : Controller
    {

        Estudiante Db = new Estudiante();

        //GET: Nuevo
        public ActionResult Index()
        {
            var listado = Db.lista();
            return View(listado.ToList());

        }


        [HttpPost]
        public ActionResult Index(string txtbuscar, string busc, string rd)
        {
            var listado = Db.lista();
            string formato = txtbuscar.Trim();
            var query = from a in Db.lista() select a;
            #region usandoSelec
            if (formato != "")
            {
                if (busc == "0")
                {
                    if (busc == "1")
                    {
                        query = from n in Db.lista() where n.Nombre.Contains(formato) select n;
                    }
                    if (busc == "2")
                    {
                        query = from n in Db.lista() where n.Materia.Contains(formato) select n;
                    }

                    if (busc == "3")
                    {
                        double prom = Convert.ToDouble(formato);
                        query = from n in Db.lista() where n.Promedio==prom select n;
                    }
                }
            }
            #endregion
            #region usandoradio           
            if (rd == "1")
            {
                query = from n in Db.lista() where n.Nombre.Contains(formato) select n;
            }
            if (rd == "2")
            {
                query = from n in Db.lista() where n.Materia.Contains(formato) select n;
            }

            if (rd == "3")
            {
                double prom = Convert.ToDouble(formato);
                query = from n in Db.lista() where n.Promedio == prom select n;
            }
            #endregion
            return View(query.ToList());

        }
    }
}