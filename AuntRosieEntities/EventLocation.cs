using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class EventLocation : RosieEntity
    {
        private long id;
        private string name;
        private Address address;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                this.address = value;
            }
        }

        public long Id { get => id;}
        public string Name { get => name; set => name = value; }

        private void SetID(long id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblEventLocation]([LocationName], [LocationProvince], " +
                    "[LocationCity], [LocationStreet]) values " +
                    "(@name, @province, @city, @street)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter cityParam = new SqlParameter("@city", SqlDbType.VarChar, 50);
                cityParam.Value = Address.City;

                SqlParameter provinceParam = new SqlParameter("@province", SqlDbType.Char, 2);
                provinceParam.Value = Address.Province;

                SqlParameter streetParam = new SqlParameter("@street", SqlDbType.VarChar, 50);
                streetParam.Value = Address.Street;

                createPrepCmd.Parameters.Add(nameParam);
                createPrepCmd.Parameters.Add(cityParam);
                createPrepCmd.Parameters.Add(provinceParam);
                createPrepCmd.Parameters.Add(streetParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
                createPrepCmd.Parameters["@city"].Value = Address.City;
                createPrepCmd.Parameters["@province"].Value = Address.Province;
                createPrepCmd.Parameters["@street"].Value = Address.Street;
            }

            id = Connector.Insert(createPrepCmd, true, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblEventLocation] where [LocationID]=@ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = Id;

                deletePrepCmd.Parameters.Add(idParam);

                deletePrepCmd.Prepare();
            }
            else
            {
                deletePrepCmd.Parameters["@ID"].Value = Id;
            }

            Connector.Delete(deletePrepCmd, transaction);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblEventLocation] set [LocationName]=@name, [LocationProvince]=@province, " +
                    "[LocationCity]=@city, [LocationStreet]=@street where [LocationID]=@ID";

                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = Id;

                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter cityParam = new SqlParameter("@city", SqlDbType.VarChar, 50);
                cityParam.Value = Address.City;

                SqlParameter provinceParam = new SqlParameter("@province", SqlDbType.Char, 2);
                provinceParam.Value = Address.Province;

                SqlParameter streetParam = new SqlParameter("@street", SqlDbType.VarChar, 50);
                streetParam.Value = Address.Street;

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(nameParam);
                updatePrepCmd.Parameters.Add(cityParam);
                updatePrepCmd.Parameters.Add(provinceParam);
                updatePrepCmd.Parameters.Add(streetParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@name"].Value = Name;
                updatePrepCmd.Parameters["@city"].Value = Address.City;
                updatePrepCmd.Parameters["@province"].Value = Address.Province;
                updatePrepCmd.Parameters["@street"].Value = Address.Street;
            }

            id = Connector.Update(updatePrepCmd, transaction);
        }

        /// <summary>
        /// Retrieve location
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static EventLocation Retrieve(long id)
        {
            EventLocation location = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [LocationName], [LocationProvince], [LocationCity], [LocationStreet] " +
                    "from [tblEventLocation] where [LocationID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = id;

                retrieveIdPrepCmd.Parameters.Add(idParam);

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["@ID"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                location = new EventLocation();
                location.SetID(id);
                location.Name = reader.IsDBNull(0) ? null : reader.GetString(0);
                location.Address = new Address(reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }

            reader.Close();

            return location;
        }

        /// <summary>
        /// Get event locations
        /// </summary>
        /// <returns></returns>
        public static List<EventLocation> GetLocations()
        {
            List<EventLocation> locations = new List<EventLocation>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [LocationID], [LocationName], [LocationProvince], " +
                "[LocationCity], [LocationStreet] from [tblEventLocation]");
            while (reader.HasRows && reader.Read())
            {
                EventLocation location = new EventLocation();
                location.SetID(reader.GetInt64(0));
                location.Name = reader.IsDBNull(1)?null: reader.GetString(1);
                location.Address = new Address(reader.GetString(2), reader.GetString(3), reader.GetString(4));

                locations.Add(location);
            }

            reader.Close();

            return locations;
        }

        public override string ToString()
        {
            return $"{(Name != null && Name != ""? $"{Name},": "")} {Address.ToString()}".Trim();
        }
    }
}