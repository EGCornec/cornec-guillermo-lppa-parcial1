using cornec_guillermo_lppa_parcial1.Data;
using cornec_guillermo_lppa_parcial1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cornec_guillermo_lppa_parcial1.Business
{
    public class Afiliado_biz
    {
        /// <param name="model"></param>
        public void Agregar(Afiliado model)
        {
            var db = new BaseDataService<Afiliado>();
            db.Create(model);

        }

        public List<Afiliado> Listar()
        {
            var db = new BaseDataService<Afiliado>();
            var lista = db.Get();
            return lista;
        }

        public Afiliado Get(int id)
        {
            var db = new BaseDataService<Afiliado>();
            return db.GetById(id);
        }


        public void Eliminar(Afiliado model)
        {
            var db = new BaseDataService<Afiliado>();
            db.Delete(model);
        }
        public void Update(Afiliado model)
        {
            var db = new BaseDataService<Afiliado>();
            db.Update(model);
        }
    }
}