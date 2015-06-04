using PointrestServerSide.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    class PuntiInteresseRepository : IRepository<PuntoInteresse>
    {
        string mConnectionString;
        const string PUNTI_INTERESSE_TABLE = "PuntiInteresse";
        const string IMMAGINI_TABLE = "Immagini";

        public PuntiInteresseRepository()
            : this("mConnectionString")
        {
            
        }

        public PuntiInteresseRepository(string connectionString)
        {
            var cs = ConfigurationManager.ConnectionStrings[connectionString];
            if (cs == null)
                throw new ApplicationException(string.Format("ConnectionString '{0}' not found", connectionString));

            else mConnectionString = cs.ConnectionString;
        }

        IEnumerable<PuntoInteresse> IRepository<PuntoInteresse>.GetAll()
        {
            List<PuntoInteresse> puntiInteresse = new List<PuntoInteresse>();

            using (var connection = new SqlConnection(mConnectionString))
            {
                connection.Open();

                string query = @"SELECT * from PuntiInteresse Left Outer Join Immagini "
                                + "on PuntiInteresse.ID = Immagini.PuntointeresseID";

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        PuntoInteresse tmp = null;
                        var tmpID = -1;
                        var index = 0;

                        while (reader.Read())
                        {
                            var ID = 0;
                            if(tmpID !=  (ID = reader.GetValue<int>("ID")) ){
                                tmp = new PuntoInteresse();
                                tmp.ID = ID;
                                tmp.IDGestore = reader.GetValue<int>("IDGestore");
                                tmp.Nome = reader.GetValue<string>("Nome");
                                tmp.Categoria = reader.GetValue<string>("Categoria");
                                tmp.Sottocategoria = reader.GetValue<string>("Descrizione");
                                tmp.Latitudine = reader.GetValue<double>("Latitudine");
                                tmp.Longitudine = reader.GetValue<double>("Longitudine");
                                tmp.Tipo = reader.GetValue<string>("Tipo");
                                tmp.Images.Add(reader.GetValue<string>("Image"));

                                puntiInteresse.Add(tmp);
                                index++;

                                tmpID = ID;
                            }
                            else
                            {
                                //tmp.Images.Add(reader.GetValue<string>("Image"));
                                puntiInteresse[index - 1].Images.Add(reader.GetValue<string>("Image"));
                            }


                        }
                    }
                }

            }

            return puntiInteresse;
        }

        PuntoInteresse IRepository<PuntoInteresse>.Get(int id)
        {
            PuntoInteresse tmp = null;
            using (var connection = new SqlConnection(mConnectionString))
            {
                connection.Open();

                string query = @"SELECT * from PuntiInteresse Left Outer Join Immagini "
                                + "on PuntiInteresse.ID = Immagini.PuntointeresseID"
                                + " WHERE PuntiInteresse.ID = " + id;

                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        var tmpID = -1;

                        while (reader.Read())
                        {
                            var ID = 0;
                            if (tmpID != (ID = reader.GetValue<int>("ID")))
                            {
                                tmp = new PuntoInteresse();
                                tmp.ID = ID;
                                tmp.IDGestore = reader.GetValue<int>("IDGestore");
                                tmp.Nome = reader.GetValue<string>("Nome");
                                tmp.Categoria = reader.GetValue<string>("Categoria");
                                tmp.Sottocategoria = reader.GetValue<string>("Descrizione");
                                tmp.Latitudine = reader.GetValue<double>("Latitudine");
                                tmp.Longitudine = reader.GetValue<double>("Longitudine");
                                tmp.Tipo = reader.GetValue<string>("Tipo");
                                tmp.Images.Add(reader.GetValue<string>("Image"));

                                tmpID = ID;
                            }
                            else
                            {
                                tmp.Images.Add(reader.GetValue<string>("Image"));
                            }
                        }
                    }
                }
            }
            return tmp;
        }

        void IRepository<PuntoInteresse>.Post(int GestoreID, PuntoInteresse puntoInteresse)
        {
            using (var connection = new SqlConnection(mConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [dbo].[PuntiInteresse]
                                ([GestoreID]
                                ,[Nome]
                               ,[Descrizione]
                               ,[Latitudine]
                               ,[Longitudine]
                               ,[SottocategoriaID])
                                OUTPUT INSERTED.ID
                                VALUES
                               (@GestoreID
                               ,@Nome
                               ,@Descrizione
                               ,@Latitudine
                               ,@Longitudine
                               ,@SottocategoriaID)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@GestoreID", puntoInteresse.IDGestore));
                    command.Parameters.Add(new SqlParameter("@Nome", puntoInteresse.Nome));
                    command.Parameters.Add(new SqlParameter("@Descrizione", puntoInteresse.Descrizione));
                    command.Parameters.Add(new SqlParameter("@Latitudine", puntoInteresse.Latitudine));
                    command.Parameters.Add(new SqlParameter("@Longitudine", puntoInteresse.Longitudine));
                    command.Parameters.Add(new SqlParameter("@SottocategoriaID", puntoInteresse.Sottocategoria));

                    int lastID = (int)command.ExecuteScalar();

                    connection.Close();

                    //return lastID;
                }
            }
        }

        void IRepository<PuntoInteresse>.Put(PuntoInteresse myObject)
        {
            throw new NotImplementedException();
        }

        void IRepository<PuntoInteresse>.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
