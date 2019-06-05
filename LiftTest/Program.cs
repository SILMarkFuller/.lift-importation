using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using SIL.Lift.Parsing;

namespace LiftTest
{
    class Program
    {
        private static ILexiconMerger<LiftObject, LiftEntry, LiftSense, LiftExample> flexImporter;

        static void Main(string[] args)
        {
            String line;
            try
            {
                //Import the LIFT file and ranges file.
                //m_progressDlg.Message = LexTextControls.ksLoadingVariousLists;
                //var flexImporter = new MongoLiftMerger(cache, Import, chkTrustModTimes.Checked);
                var flexImporter = new LiftToCombine();
                var parser = new LiftParser<LiftObject, LiftEntry, LiftSense, LiftExample>(flexImporter);
               
                parser.SetTotalNumberSteps += parser_SetTotalNumberSteps;
                parser.SetStepsCompleted += parser_SetStepsCompleted;
                parser.SetProgressMessage += parser_SetProgressMessage;

//                flexImporter.LiftFile = sTempOrigFile;

                //Before imporing the LIFT files ensure the LDML (language definition files) have the correct writing system codes.
                //flexImporter.LdmlFilesMigration(sLIFTtempFolder, sFilename, sTempOrigFile + "-ranges");
                //Import the Ranges file.
                //flexImporter.LoadLiftRanges(sTempOrigFile + "-ranges"); // temporary (?) fix for FWR-3869.
                                                                        //Import the LIFT data file.
                int cEntries = parser.ReadLiftFile("C:\\Users\\FullerM\\Documents\\LiftTest\\LiftTest\\testingdata\\testingdata.lift");

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private static void parser_SetProgressMessage(object sender, LiftParser<LiftObject, LiftEntry, LiftSense, LiftExample>.MessageArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void parser_SetStepsCompleted(object sender, LiftParser<LiftObject, LiftEntry, LiftSense, LiftExample>.ProgressEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private static void parser_SetTotalNumberSteps(object sender, LiftParser<LiftObject, LiftEntry, LiftSense, LiftExample>.StepsArgs e)
        {
            //throw new NotImplementedException();
        }

        public class SkipObject : LiftObject
        {
            public SkipObject()
            {
                
            }

            public override string XmlTag => throw new NotImplementedException();
        }
        public class SkipEntry : LiftEntry
        {
            public SkipEntry()
            {

            }

            public override string XmlTag => throw new NotImplementedException();
        }
        public class SkipSense : LiftSense
        {
            public SkipSense()
            {

            }

            public override string XmlTag => throw new NotImplementedException();
        }
        public class SkipExample : LiftExample
        {
            public SkipExample()
            {

            }

            public override string XmlTag => throw new NotImplementedException();
        }





        public class LiftToCombine : ILexiconMerger<LiftObject, LiftEntry, LiftSense, LiftExample>
        {
            public void EntryWasDeleted(Extensible info, DateTime dateDeleted)
            {
               throw new NotImplementedException();
            }

            public void FinishEntry(LiftEntry entry)
            {
                Console.WriteLine("Upload document to mongo");
                //throw new NotImplementedException();
            }

            public LiftEntry GetOrMakeEntry(Extensible info, int order)
            {

                // throw new NotImplementedException();
                LiftEntry dave = new LiftEntry();
                return new SkipEntry();
            }

            public LiftExample GetOrMakeExample(LiftSense sense, Extensible info)
            {
                // throw new NotImplementedException();
                LiftEntry dave = new LiftEntry();
                return new SkipExample();
            }

            public LiftObject GetOrMakeParentReversal(LiftObject parent, LiftMultiText contents, string type)
            {
                // throw new NotImplementedException();
                LiftEntry dave = new LiftEntry();
                return new SkipObject();
            }

            public LiftSense GetOrMakeSense(LiftEntry entry, Extensible info, string rawXml)
            {
                // throw new NotImplementedException();
                LiftSense dave = new LiftSense();
                return new SkipSense();
            }

            public LiftSense GetOrMakeSubsense(LiftSense sense, Extensible info, string rawXml)
            {
                //throw new NotImplementedException();
                LiftSense dave = new LiftSense();
                return new SkipSense();
            }

            public void MergeInCitationForm(LiftEntry entry, LiftMultiText contents)
            {
                // throw new NotImplementedException();
                LiftEntry dave = new LiftEntry();
            }

            public void MergeInDefinition(LiftSense sense, LiftMultiText liftMultiText)
            {
                // throw new NotImplementedException();
            }

            public LiftObject MergeInEtymology(LiftEntry entry, string source, string type, LiftMultiText form, LiftMultiText gloss, string rawXml)
            {
                // throw new NotImplementedException();
               
                return new SkipObject();
            }

            public void MergeInExampleForm(LiftExample example, LiftMultiText multiText)
            {
                //throw new NotImplementedException();
            }

            public void MergeInField(LiftObject extensible, string typeAttribute, DateTime dateCreated, DateTime dateModified, LiftMultiText contents, List<Trait> traits)
            {
               // throw new NotImplementedException();
            }

            public void MergeInGloss(LiftSense sense, LiftMultiText multiText)
            {
               // throw new NotImplementedException();
            }

            public void MergeInGrammaticalInfo(LiftObject senseOrReversal, string val, List<Trait> traits)
            {
                //throw new NotImplementedException();
            }

            public void MergeInLexemeForm(LiftEntry entry, LiftMultiText contents)
            {
                //throw new NotImplementedException();
            }

            public void MergeInMedia(LiftObject pronunciation, string href, LiftMultiText caption)
            {
               // throw new NotImplementedException();
            }

            public void MergeInNote(LiftObject extensible, string type, LiftMultiText contents, string rawXml)
            {
                //throw new NotImplementedException();
            }

            public void MergeInPicture(LiftSense sense, string href, LiftMultiText caption)
            {
               // throw new NotImplementedException();
            }

            public LiftObject MergeInPronunciation(LiftEntry entry, LiftMultiText contents, string rawXml)
            {
                // throw new NotImplementedException();
                return new SkipObject();
            }

            public void MergeInRelation(LiftObject extensible, string relationTypeName, string targetId, string rawXml)
            {
                //throw new NotImplementedException();
            }

            public LiftObject MergeInReversal(LiftSense sense, LiftObject parent, LiftMultiText contents, string type, string rawXml)
            {
                // throw new NotImplementedException();
                return new SkipObject();
            }

            public void MergeInSource(LiftExample example, string source)
            {
                //throw new NotImplementedException();
            }

            public void MergeInTrait(LiftObject extensible, Trait trait)
            {
                //throw new NotImplementedException();
            }

            public void MergeInTranslationForm(LiftExample example, string type, LiftMultiText multiText, string rawXml)
            {
                //throw new NotImplementedException();
            }

            public LiftObject MergeInVariant(LiftEntry entry, LiftMultiText contents, string rawXml)
            {
                //throw new NotImplementedException();
                LiftEntry dave = new LiftEntry();
                return new SkipObject();
            }

            public void ProcessFieldDefinition(string tag, LiftMultiText description)
            {
                //throw new NotImplementedException();
            }

            public void ProcessRangeElement(string range, string id, string guid, string parent, LiftMultiText description, LiftMultiText label, LiftMultiText abbrev, string rawXml)
            {
                Console.WriteLine("{");
                //throw new NotImplementedException();
                Console.WriteLine("range:" + range);
                Console.WriteLine("id:" + id);
                Console.WriteLine("guid:" + guid);
                Console.WriteLine("parent:" + parent);
                Console.WriteLine("description:" + description.ToString());
                Console.WriteLine("label:" + label.ToString());
                Console.WriteLine("abbrev:" + abbrev.ToString());
                Console.WriteLine("}");
            }
        }
    }
}
