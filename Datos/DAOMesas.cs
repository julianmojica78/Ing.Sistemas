using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Utilitarios;

namespace Datos
{
    public class DAOMesas
    {
        public void insertMesa(Mesas mesas)
        {
            using (var db = new Mapeo("mesa"))
            {
                db.mesa.Add(mesas);
                db.SaveChanges();
            }
        }
        public void actualizarMesas(Mesas mesas)
        {
            using (var db = new Mapeo("mesa"))
            {
                db.mesa.Attach(mesas);
                var entry = db.Entry(mesas);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void borrarMesa(Mesas mesas)
        {
            using (var db = new Mapeo("mesa"))
            {
                db.mesa.Attach(mesas);
                db.Entry(mesas).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Mesas> obtenerMesar()
        {
            using (var db = new Mapeo("mesa"))
            {
                var a = db.mesa.ToList<Mesas>();
                return a.ToList<Mesas>();

            }

        }
    }
}
