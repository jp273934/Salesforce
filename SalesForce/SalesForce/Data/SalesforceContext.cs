using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SalesForce.Data
{
    public class SalesforceContext : DbContext
    {
        public SalesforceContext() : base("Salesforce")
        {

        }
    }
}