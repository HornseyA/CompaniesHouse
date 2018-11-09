using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCompaniesHouseAPITest
{
    class Company
    {
        public string company_number { get; set; }

        public string company_name { get; set; }

        public Account accounts { get; set; }

        public Address registered_office_address { get; set; }

        public string eTag { get; set; }

        public DateTime date_of_creation { get; set; }

        public string type { get; set; }

        public List<string> sic_codes { get; set; }

        public string company_status { get; set; }

        public string jurisdiction { get; set; }

        public DateTime last_full_members_list_date { get; set; }

        public bool has_charges { get; set; }

        public bool undeliverable_registered_office_address { get; set; }

        public List<Statment> confirmation_statement { get; set; }


    }
