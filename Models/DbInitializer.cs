using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace site.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<LearnYourRightsDb>
    {
        protected override void Seed(LearnYourRightsDb context)
        {
            base.Seed(context);

            context.SiteProperties.Add(new SiteProperty
                                           {
                                               PropertyName = "HomePageContent",
                                               PropertyText =
                                                   @"Dealing with a severe personal injury can be devastating, physically, emotionally and financially. Wouldn't it be comforting to have an injury lawyer who is highly experienced and who puts your interests first?
                                                    At McGrath Gibson, our Jacksonville Florida personal injury attorneys don't just talk about personal service, we strive to get to know all of our clients and their needs. We then target our exemplary skills toward achieving the best possible results, whether in the courtroom or at the negotiating table.
                                                    Our partners have handled thousands of injury and negligence cases across the state. Clients also benefit from our years of experience in insurance defense, which affords us the knowledge and tenacity to take on powerful defense firms in even the most complex cases.
                                                    Clients from across Florida seek our counsel when they or a family member have been injured or killed in an auto accident or truck accident, by medical malpractice, in a nursing home or on the job.
                                                    Don't agonize about your case. See the difference a seasoned, client-centric law firm can make.
                                                    Serving personal injury, wrongful death, medical malpractice and workers' compensation clients in Jacksonville, Duval, Clay, St. Johns, Alachua, Putnam, Volusia, Palm Beach, Broward, Dade counties in Florida.",
                                               Test = "testing"
                                           });

            var personalInjury = new PracticeArea
                                     {
                                         Name = "Personal Injury",
                                         Description = "Personal Injury Description"
                                     };

            var autoAccidents = new PracticeArea
                                    {
                                        Name = "Auto Accidents",
                                        Description = "Auto Accidents Description"
                                    };

            var truckingAccidents = new PracticeArea
                                        {
                                            Name = "Trucking Accidents",
                                            Description = "Trucking Accidents Description"
                                        };

            var wrongfulDeath = new PracticeArea
                                    {
                                        Name = "Wrongful Death",
                                        Description = "Wrongful Death Description"
                                    };

            var workersComp = new PracticeArea
                                  {
                                      Name = "Workers' Compensation",
                                      Description = "Workers' Compensation Description"
                                  };

            var floridaBarMcGrath = new Admission
                                        {
                                            Name = "The Florida Bar",
                                            Link = "http://www.flabar.org/"
                                        };

            var ncBarMcGrath = new Admission
                                   {
                                       Name = "The North Carolina Bar",
                                       Link = "http://www.ncbar.gov/"
                                   };

            var fcslMcGrath = new Education
                                  {
                                      Name = "Florida Coastal School of Law",
                                      Link = "http://www.fcsl.edu/"
                                  };

            var unfMcGrath = new Education
                                 {
                                     Name = "University of North Florida",
                                     Link = "http://www.unf.edu/"
                                 };

            var aaFloridaBarMcGrath = new AttorneyAdmission
                                          {
                                              Admission = floridaBarMcGrath,
                                              Year = 2002
                                          };

            var aaNcBarMcGrath = new AttorneyAdmission
                                     {
                                         Admission = ncBarMcGrath,
                                         Year = 2009
                                     };

            var aeFcslMcGrath = new AttorneyEducation
                                    {
                                        Education = fcslMcGrath,
                                        Degree = "Juris Doctorate"
                                    };

            var aeUnfMcGrath = new AttorneyEducation
                                   {
                                       Education = unfMcGrath,
                                       Degree = "B.B.A."
                                   };

            var jacksonville = new Birthplace
                                   {
                                       Name = "Jacksonville, FL",
                                       Link = "http://en.wikipedia.org/wiki/Jacksonville,_Florida"
                                   };

            context.Attorneys.Add(new Attorney
                                      {
                                          FirstName = "Michael",
                                          LastName = "McGrath",
                                          MiddleInitial = "D.",
                                          Birthplace = jacksonville,
                                          Title = "Managing Partner",
                                          Admissions = new HashSet<AttorneyAdmission>()
                                                           {
                                                               aaFloridaBarMcGrath,
                                                               aaNcBarMcGrath
                                                           },
                                          Educations = new HashSet<AttorneyEducation>
                                                           {
                                                               aeFcslMcGrath,
                                                               aeUnfMcGrath
                                                           },
                                          PracticeAreas = new HashSet<PracticeArea>
                                                              {
                                                                 personalInjury,
                                                                 autoAccidents,
                                                                 truckingAccidents,
                                                                 wrongfulDeath,
                                                                 workersComp
                                                              }
                                      });

            context.PracticeAreas.Add(personalInjury);
            context.PracticeAreas.Add(autoAccidents);
            context.PracticeAreas.Add(truckingAccidents);
            context.PracticeAreas.Add(wrongfulDeath);
            context.PracticeAreas.Add(workersComp);

            context.Admissions.Add(floridaBarMcGrath);
            context.Admissions.Add(ncBarMcGrath);

            context.Educations.Add(fcslMcGrath);
            context.Educations.Add(unfMcGrath);

            context.AttorneyAdmissions.Add(aaNcBarMcGrath);
            context.AttorneyAdmissions.Add(aaFloridaBarMcGrath);

            context.AttorneyEducations.Add(aeUnfMcGrath);
            context.AttorneyEducations.Add(aeFcslMcGrath);

            context.Birthplaces.Add(jacksonville);
        }
    }
}