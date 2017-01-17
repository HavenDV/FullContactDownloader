using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace FullContactDownloader
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-FullContact-APIKey", "97a086b3aac1b0a5");
            var response = await client.GetAsync(
                "https://api.fullcontact.com/v2/company/lookup.json?domain=fullcontact.com");
            var responseContent = response.Content;
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                var company = JsonConvert.DeserializeObject<Company>(await reader.ReadToEndAsync());
                ConsoleRichBox.AppendText(company.languageLocale + Environment.NewLine);
            }
        }
    }

    public class Category
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class EmailAddress
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class PhoneNumber
    {
        public string number { get; set; }
        public string label { get; set; }
    }

    public class Region
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Address
    {
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string locality { get; set; }
        public Region region { get; set; }
        public Country country { get; set; }
        public string postalCode { get; set; }
        public string label { get; set; }
    }

    public class ContactInfo
    {
        public List<EmailAddress> emailAddresses { get; set; }
        public List<PhoneNumber> phoneNumbers { get; set; }
        public List<Address> addresses { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string label { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public string label { get; set; }
    }

    public class Organization
    {
        public string name { get; set; }
        public int approxEmployees { get; set; }
        public string founded { get; set; }
        public string overview { get; set; }
        public ContactInfo contactInfo { get; set; }
        public List<Link> links { get; set; }
        public List<Image> images { get; set; }
        public List<string> keywords { get; set; }
    }

    public class SocialProfile
    {
        public string bio { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public string typeId { get; set; }
        public string typeName { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string id { get; set; }
    }

    public class TopCountryRanking
    {
        public int rank { get; set; }
        public string locale { get; set; }
    }

    public class Ranking
    {
        public int rank { get; set; }
        public string locale { get; set; }
    }

    public class Traffic
    {
        public List<TopCountryRanking> topCountryRanking { get; set; }
        public List<Ranking> ranking { get; set; }
    }

    public class Company
    {
        public int status { get; set; }
        public string requestId { get; set; }
        public List<Category> category { get; set; }
        public string logo { get; set; }
        public string website { get; set; }
        public string languageLocale { get; set; }
        public Organization organization { get; set; }
        public List<SocialProfile> socialProfiles { get; set; }
        public Traffic traffic { get; set; }
    }
}
