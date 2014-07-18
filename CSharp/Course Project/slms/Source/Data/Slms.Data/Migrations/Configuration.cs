namespace Slms.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Slms.Common;
    using Slms.Data.Models;

    public sealed class Configuration : DbMigrationsConfiguration<SlmsDbContext>
    {
        private const int SampleItemsGenerationCount = 10;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SlmsDbContext context)
        {
            this.SeedCountries(context);
            this.SeedAuthors(context);
            this.SeedPublishers(context);
            this.SeedCategories(context);
            this.SeedTags(context);
            this.SeedBooks(context);
        }

        private void SeedCountries(ISlmsDbContext context)
        {
            if (!context.Countries.Any())
            {
                var countryNames = new List<string>()
                {
                    "Неизбрана",
                    "Afghanistan",
                    "Albania",
                    "Algeria",
                    "American Samoa",
                    "Andorra",
                    "Angola",
                    "Anguilla",
                    "Antarctica",
                    "Antigua and Barbuda",
                    "Argentina",
                    "Armenia",
                    "Aruba",
                    "Australia",
                    "Austria",
                    "Azerbaijan",
                    "Bahamas",
                    "Bahrain",
                    "Bangladesh",
                    "Barbados",
                    "Belarus",
                    "Belgium",
                    "Belize",
                    "Benin",
                    "Bermuda",
                    "Bhutan",
                    "Bolivia",
                    "Bosnia and Herzegovina",
                    "Botswana",
                    "Brazil",
                    "Brunei Darussalam",
                    "Bulgaria",
                    "Burkina Faso",
                    "Burundi",
                    "Cambodia",
                    "Cameroon",
                    "Canada",
                    "Cape Verde",
                    "Cayman Islands",
                    "Central African Republic",
                    "Chad",
                    "Chile",
                    "China",
                    "Christmas Island",
                    "Cocos (Keeling) Islands",
                    "Colombia",
                    "Comoros",
                    "Democratic Republic of the Congo (Kinshasa)",
                    "Congo, Republic of (Brazzaville)",
                    "Cook Islands",
                    "Costa Rica",
                    "Ivory Coast",
                    "Croatia",
                    "Cuba",
                    "Cyprus",
                    "Czech Republic",
                    "Denmark",
                    "Djibouti",
                    "Dominica",
                    "Dominican Republic",
                    "East Timor (Timor-Leste)",
                    "Ecuador",
                    "Egypt",
                    "El Salvador",
                    "Equatorial Guinea",
                    "Eritrea",
                    "Estonia",
                    "Ethiopia",
                    "Falkland Islands",
                    "Faroe Islands",
                    "Fiji",
                    "Finland",
                    "France",
                    "French Guiana",
                    "French Polynesia",
                    "French Southern Territories",
                    "Gabon",
                    "Gambia",
                    "Georgia",
                    "Germany",
                    "Ghana",
                    "Gibraltar",
                    "Great Britain",
                    "Greece",
                    "Greenland",
                    "Grenada",
                    "Guadeloupe",
                    "Guam",
                    "Guatemala",
                    "Guinea",
                    "Guinea-Bissau",
                    "Guyana",
                    "Haiti",
                    "Holy See",
                    "Honduras",
                    "Hong Kong",
                    "Hungary",
                    "Iceland",
                    "India",
                    "Indonesia",
                    "Iran (Islamic Republic of)",
                    "Iraq",
                    "Ireland",
                    "Israel",
                    "Italy",
                    "Jamaica",
                    "Japan",
                    "Jordan",
                    "Kazakhstan",
                    "Kenya",
                    "Kiribati",
                    "Korea, Democratic People's Rep. (North Korea)",
                    "Korea, Republic of (South Korea)",
                    "Kosovo",
                    "Kuwait",
                    "Kyrgyzstan",
                    "Lao, People's Democratic Republic",
                    "Latvia",
                    "Lebanon",
                    "Lesotho",
                    "Liberia",
                    "Libya",
                    "Liechtenstein",
                    "Lithuania",
                    "Luxembourg",
                    "Macau",
                    "Macedonia, Rep. of",
                    "Madagascar",
                    "Malawi",
                    "Malaysia",
                    "Maldives",
                    "Mali",
                    "Malta",
                    "Marshall Islands",
                    "Martinique",
                    "Mauritania",
                    "Mauritius",
                    "Mayotte",
                    "Mexico",
                    "Micronesia, Federal States of",
                    "Moldova, Republic of",
                    "Monaco",
                    "Mongolia",
                    "Montenegro",
                    "Montserrat",
                    "Morocco",
                    "Mozambique",
                    "Myanmar, Burma",
                    "Namibia",
                    "Nauru",
                    "Nepal",
                    "Netherlands",
                    "Netherlands Antilles",
                    "New Caledonia",
                    "New Zealand",
                    "Nicaragua",
                    "Niger",
                    "Nigeria",
                    "Niue",
                    "Northern Mariana Islands",
                    "Norway",
                    "Oman",
                    "Pakistan",
                    "Palau",
                    "Palestinian territories",
                    "Panama",
                    "Papua New Guinea",
                    "Paraguay",
                    "Peru",
                    "Philippines",
                    "Pitcairn Island",
                    "Poland",
                    "Portugal",
                    "Puerto Rico",
                    "Qatar",
                    "Reunion Island",
                    "Romania",
                    "Russian Federation",
                    "Rwanda",
                    "Saint Kitts and Nevis",
                    "Saint Lucia",
                    "Saint Vincent and the Grenadines",
                    "Samoa",
                    "San Marino",
                    "Sao Tome and Principe",
                    "Saudi Arabia",
                    "Senegal",
                    "Serbia",
                    "Seychelles",
                    "Sierra Leone",
                    "Singapore",
                    "Slovakia (Slovak Republic)",
                    "Slovenia",
                    "Solomon Islands",
                    "Somalia",
                    "South Africa",
                    "South Sudan",
                    "Spain",
                    "Sri Lanka",
                    "Sudan",
                    "Suriname",
                    "Swaziland",
                    "Sweden",
                    "Switzerland",
                    "Syria, Syrian Arab Republic",
                    "Taiwan (Republic of China)",
                    "Tajikistan",
                    "Tanzania; officially the United Republic of Tanzania",
                    "Thailand",
                    "Tibet",
                    "Timor-Leste (East Timor)",
                    "Togo",
                    "Tokelau",
                    "Tonga",
                    "Trinidad and Tobago",
                    "Tunisia",
                    "Turkey",
                    "Turkmenistan",
                    "Turks and Caicos Islands",
                    "Tuvalu",
                    "Uganda",
                    "Ukraine",
                    "United Arab Emirates",
                    "United Kingdom",
                    "United States",
                    "Uruguay",
                    "Uzbekistan",
                    "Vanuatu",
                    "Vatican City State (Holy See)",
                    "Venezuela",
                    "Vietnam",
                    "Virgin Islands (British)",
                    "Virgin Islands (U.S.)",
                    "Wallis and Futuna Islands",
                    "Western Sahara",
                    "Yemen",
                    "Zambia",
                    "Zimbabwe"
                };

                foreach (var countryName in countryNames)
                {
                    context.Countries.Add(new Country { Name = countryName });
                }

                context.SaveChanges();
            }
        }

        private void SeedAuthors(ISlmsDbContext context)
        {
            if (!context.Authors.Any())
            {
                var numberOfCountries = context.Countries.Count();

                for (int i = 0; i < SampleItemsGenerationCount; i++)
                {
                    context.Authors.Add(new Author()
                    {
                        Name = "Sample Author " + i,
                        BirthDay = DateTime.Now,
                        CountryId = RandomGenerator.Instance.Next(1, numberOfCountries)
                    });
                }

                context.SaveChanges();
            }
        }

        private void SeedPublishers(ISlmsDbContext context)
        {
            if (!context.Publishers.Any())
            {
                for (int i = 0; i < SampleItemsGenerationCount; i++)
                {
                    context.Publishers.Add(new Publisher()
                    {
                        Name = "Sample Publisher " + i,
                        Adress = "Sample Address " + i
                    });
                }

                context.SaveChanges();
            }
        }

        private void SeedCategories(ISlmsDbContext context)
        {
            if (!context.Categories.Any())
            {
                for (int i = 0; i < SampleItemsGenerationCount; i++)
                {
                    context.Categories.Add(new Category()
                    {
                        Name = "Sample Category" + i,
                    });
                }

                context.SaveChanges();
            }
        }

        private void SeedTags(ISlmsDbContext context)
        {
            if (!context.Tags.Any())
            {
                for (int i = 0; i < SampleItemsGenerationCount; i++)
                {
                    context.Tags.Add(new Tag()
                    {
                        Name = "SampleTag" + i,
                    });
                }

                context.SaveChanges();
            }
        }

        private void SeedBooks(SlmsDbContext context)
        {
            if (!context.Books.Any())
            {
                var tags = context.Tags.ToList();
                var categories = context.Categories.ToList();
                var authors = context.Authors.ToList();
                var publishers = context.Publishers.ToList();

                for (int i = 0; i < SampleItemsGenerationCount; i++)
                {
                    var book = new Book()
                    {
                        Title = "Sample book " + i,
                        Category = categories[RandomGenerator.Instance.Next(0, categories.Count)],
                        Author = authors[RandomGenerator.Instance.Next(0, authors.Count)],
                        Publisher = publishers[RandomGenerator.Instance.Next(0, publishers.Count)],
                    };

                    book.Tags.Add(tags[RandomGenerator.Instance.Next(0, tags.Count)]);

                    context.Books.Add(book);
                }

                context.SaveChanges();
            }
        }
    }
}
