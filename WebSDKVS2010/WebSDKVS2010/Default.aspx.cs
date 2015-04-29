using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Us.Onboardis.Demo2.OnboardInformatics;
using Us.Onboardis.Demo2.OnboardInformatics.Api;

namespace WebSDKVS2010
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Resource: Property */
            
            Label1.Text = "Calling endpoint: Property Address";
            testAddressProperty();

            Label3.Text = "Calling endpoint: Property Apn";
            testApnProperty();

            Label5.Text = "Calling endpoint: Property Enumeration";
            testEnumerationProperty();

            Label7.Text = "Calling endpoint: Property ID Summary";
            testIdProperty();

            Label9.Text = "Calling endpoint: Propery Metadata";
            testMetadataProperty();
            
            /* Resource: Properties */

            Label11.Text = "Calling endpoint: Properties ID Postal ";
            testIdsProperties();

            Label13.Text = "Calling endpoint: Properties Address Postal";
            testPostalAddressProperties();

            Label15.Text = "Calling endpoint: Properties Snapshots Postal";
            testSnapshotsProperties();

            Label17.Text = "Calling endpoint: Properties Summaries Bbox";
            testSummariesProperties();

            Label19.Text = "Calling endpoint: Properties Summary Postal";
            testSummaryProperties();

            Label21.Text = "Calling endpoint: Properties Summary Radius";
            testSummaryRadiusProperties();

            Label23.Text = "Calling endpoint: Properties Summaries Zip";
            testZipSummariesProperties();

            Label25.Text = "Calling endpoint: Properties Summary Radius";
            testSummaryRadiusAddressProperties();

            Label27.Text = "Calling endpoint: Properties Summaries Postal";
            testSummariesPostalProperties();
            
            Label29.Text = "Calling endpoint: Property Address Summary";
            testAddressSummaryProperty();
            
        }

        public void testAddressProperty()
        {
            String address = "1501 LAKEWOOD DR, WILMINGTON DE 19803";  // Address
            String filter = "coolingType ne CENTRAL";  // Filter

            try
            {
                // first arguemnt 'basePath' is optional
                PropertyApi propertyApi = new PropertyApi("http://demo2.onboardis.us");
                Label2.Text = propertyApi.Address(address, filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public void testAddressSummaryProperty()
        {
            String address = "1501 LAKEWOOD DR, WILMINGTON DE 19803";  // Address
            String filter = "coolingType ne CENTRAL";  // Filter

            try
            {
                // first arguemnt 'basePath' is optional
                PropertyApi propertyApi = new PropertyApi("http://demo2.onboardis.us");
                Label30.Text = propertyApi.AddressSummary(address, filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void testApnProperty()
        {
            try
            {
                // first arguemnt 'basePath' is optional
                PropertyApi propertyApi = new PropertyApi("http://demo2.onboardis.us");
                Label4.Text = propertyApi.Apn();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testEnumerationProperty()
        {
            try
            {
                // first arguemnt 'basePath' is optional
                PropertyApi propertyApi = new PropertyApi("http://demo2.onboardis.us");
                Label6.Text = propertyApi.Enumeration();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testIdProperty()
        {
            try
            {
                // first arguemnt 'basePath' is optional
                PropertyApi propertyApi = new PropertyApi("http://demo2.onboardis.us");
                Label8.Text = propertyApi.Id();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testMetadataProperty()
        {
            try
            {
                // first arguemnt 'basePath' is optional
                PropertyApi propertyApi = new PropertyApi("http://demo2.onboardis.us");
                Label10.Text =  propertyApi.Metadata();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testIdsProperties()
        {
            String postal = "19980";  // Geoformat


            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label12.Text = propertiesApi.Ids(postal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testPostalAddressProperties()
        {
            String postal = "19968";  // Geoformat
            String page = "1";  // Page
            String size = "30";  // Size
            String filter = "";  // Filter
           

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label14.Text = propertiesApi.PostalAddress(postal, page, size, filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testSnapshotsProperties()
        {
            String postal = "19964";  // Geoformat
            String page = "1";  // Page
            String size = "30";  // Size

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label16.Text = propertiesApi.Snapshots(postal, page, size);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testSummariesProperties()
        {
            String bbox = "-75.60516357421875";  // Bbox
            String page = "1";  // Page
            String size = "30";  // Size
            String filter = "";  // Filter

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label18.Text = propertiesApi.Summaries(bbox, page, size, filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testSummaryProperties()
        {
            String postal = "19803";  // Postal

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label20.Text = propertiesApi.Summary(postal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testSummaryRadiusProperties()
        {
            String point = "-75.0517300000,38.4514870000";  // Point
            String radius = "20";  // Radius
            String unit = "mi"; //Unit
            String page = "1";  // Page
            String size = "30";  // Size

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label22.Text = propertiesApi.SummaryRadius(point, radius, unit, page, size);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testSummaryRadiusAddressProperties()
        {
            String point = "address:15+Bay+Reach+Rehoboth+Beach+DE+19971";  // Point
            String radius = "10";  // Radius
            String unit = "mi"; //Unit
            String page = "1";  // Page
            String size = "30";  // Size

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label26.Text = propertiesApi.SummaryRadiusAddress(point, radius, unit, page, size);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testZipSummariesProperties()
        {
            String zip = "19967";  // Bbox
            String page = "1";  // Page
            String size = "30";  // Size
            String filter = "";  // Filter

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label24.Text = propertiesApi.ZipSummaries(zip, page, size, filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void testSummariesPostalProperties()
        {
            String postal = "19943";  // Geoformat
            String page = "1";  // Page
            String size = "30";  // Size


            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                Label28.Text = propertiesApi.SummariesPostal(postal, page, size);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}