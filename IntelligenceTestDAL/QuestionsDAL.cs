using IntelligenceTestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceTestDAL
{
    public class QuestionsDAL
    {
        public static List<QuestionsModel> GetAllQuestions()
        {
        List<QuestionsModel> questions;
        questions = new List<QuestionsModel>
            {
                new QuestionsModel
                {
                    QuestionDetail="I enjoy categorizing things by common traits",
                    QuestionUrdu="مجھے عام خصلتوں کے مطابق چیزوں کی درجہ بندی کرنے میں لطف آتا ہے۔",
                    Id=1,
                    choice=new List<string>{"Yes","No"},
                    logicalScore=0,
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Ecological (mahawlyati) issues are important to me",
                    QuestionUrdu="میرے لیے ماحولیاتی (مہاولیاتی) مسائل اہم ہیں۔",
                    Id=2,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Hiking and camping are enjoyable activities",
                    QuestionUrdu="پیدل سفر اور کیمپنگ خوشگوار سرگرمیاں ہیں۔",
                    Id=3,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy working on a garden",
                    QuestionUrdu="مجھے باغ میں کام کرنے میں مزہ آتا ہے۔",
                    Id=4,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I believe preserving our National Parks is important",
                    QuestionUrdu="مجھے یقین ہے کہ ہمارے قومی پارکوں کا تحفظ ضروری ہے۔",
                    Id=5,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Putting things in hierarchies (darja bandi) makes sense to me",
                    QuestionUrdu="چیزوں کو درجہ بندی (درجہ بندی) میں رکھنا میرے لیے معنی خیز ہے۔",
                    Id=6,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Animals are important in my life",
                    QuestionUrdu="میری زندگی میں جانور اہم ہیں۔",
                    Id=7,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="My home has a recycling system in place",
                    QuestionUrdu="میرے گھر میں ری سائیکلنگ کا نظام موجود ہے۔",
                    Id=8,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy studying biology, botany and/or zoology",
                    QuestionUrdu="مجھے حیاتیات، نباتیات اور/یا حیوانیات کا مطالعہ کرنا اچھا لگتا ہے۔",
                    Id=9,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I spend a great deal of time outdoors",
                    QuestionUrdu="میں باہر وقت کا ایک بڑا سودا خرچ کرتا ہوں",
                    Id=10,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I easily pick up on patterns",
                    QuestionUrdu="میں آسانی سے پیٹرن پر اٹھاتا ہوں۔",
                    Id=11,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I focus in on noise and sounds",
                    QuestionUrdu="میں شور اور آواز پر توجہ مرکوز کرتا ہوں۔",
                    Id=12,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Moving to a beat is easy for me",
                    QuestionUrdu="بیٹ پر جانا میرے لیے آسان ہے۔",
                    Id=13,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I've always been interested in playing an instrument",
                    QuestionUrdu="مجھے ہمیشہ سے ایک ساز بجانے میں دلچسپی رہی ہے۔",
                    Id=14,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="The cadence (tarannum radif/qafiya) of poetry intrigues me",
                    QuestionUrdu="شاعری کا لحظہ (ترنم ردیف/قافیہ) مجھے متوجہ کرتا ہے۔",
                    Id=15,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I remember things by putting them in a rhyme",
                    QuestionUrdu="میں چیزوں کو شاعری میں رکھ کر یاد کرتا ہوں۔",
                    Id=16,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Concentration is difficult while listening to a radio or television",
                    QuestionUrdu="ریڈیو یا ٹیلی ویژن سننے کے دوران توجہ مرکوز کرنا مشکل ہے۔",
                    Id=17,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy many kinds of music",
                    QuestionUrdu="میں کئی طرح کی موسیقی سے لطف اندوز ہوتا ہوں۔",
                    Id=18,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Musicals are more interesting than dramatic plays",
                    QuestionUrdu="میوزیکل ڈرامائی ڈراموں سے زیادہ دلچسپ ہوتے ہیں۔",
                    Id=19,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Remembering song lyrics is easy for me",
                    QuestionUrdu="گانے کے بول یاد رکھنا میرے لیے آسان ہے۔",
                    Id=20,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I keep my things neat and orderly",
                    QuestionUrdu="میں اپنی چیزوں کو صاف ستھرا اور منظم رکھتا ہوں۔",
                    Id=21,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Step-by-step directions are a big help",
                    QuestionUrdu="قدم بہ قدم ہدایات ایک بڑی مدد ہیں۔",
                    Id=22,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Solving problems comes easily to me",
                    QuestionUrdu="مسائل کو حل کرنا میرے پاس آسانی سے آتا ہے۔",
                    Id=23,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I get easily frustrated with disorganized people",
                    QuestionUrdu="میں غیر منظم لوگوں سے آسانی سے مایوس ہو جاتا ہوں۔",
                    Id=24,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I can complete calculations quickly in my head",
                    QuestionUrdu="میں اپنے دماغ میں تیزی سے حساب مکمل کر سکتا ہوں۔",
                    Id=25,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Puzzles requiring reasoning are fun",
                    QuestionUrdu="پہیلیاں جن میں استدلال کی ضرورت ہوتی ہے وہ تفریحی ہیں۔",
                    Id=26,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I can't begin an assignment until all my questions are answered ",
                    QuestionUrdu="میں اسائنمنٹ شروع نہیں کر سکتا جب تک کہ میرے تمام سوالات کے جوابات نہ مل جائیں۔",
                    Id=27,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Structure helps me to be successful",
                    QuestionUrdu="ساخت مجھے کامیاب ہونے میں مدد کرتی ہے۔",
                    Id=28,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I find working on a computer spreadsheet or database rewarding",
                    QuestionUrdu="مجھے کمپیوٹر اسپریڈشیٹ یا ڈیٹا بیس پر کام کرنا فائدہ مند لگتا ہے۔",
                    Id=29,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Things have to make sense to me or I am dissatisfied",
                    QuestionUrdu="چیزوں کو میرے لئے سمجھنا ہوگا یا میں غیر مطمئن ہوں۔",
                    Id=30,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="It is important to see my role in the \"big picture\" of things",
                    QuestionUrdu="چیزوں کی \"بڑی تصویر\" میں اپنے کردار کو دیکھنا ضروری ہے۔",
                    Id=31,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy discussing questions about life",
                    QuestionUrdu="مجھے زندگی کے بارے میں سوالات پر بحث کرنے میں مزہ آتا ہے۔",
                    Id=32,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Religion is important to me",
                    QuestionUrdu="میرے لیے مذہب اہم ہے۔",
                    Id=33,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy viewing art masterpieces",
                    QuestionUrdu="مجھے آرٹ کے شاہکار دیکھنے کا لطف آتا ہے۔",
                    Id=34,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Relaxation and meditation exercises are rewarding",
                    QuestionUrdu="آرام اور مراقبہ کی مشقیں فائدہ مند ہیں۔",
                    Id=35,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I like visiting breathtaking sites in nature",
                    QuestionUrdu="مجھے فطرت میں دلکش مقامات کا دورہ کرنا پسند ہے۔",
                    Id=36,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy reading ancient and modern philosophers",
                    QuestionUrdu="مجھے قدیم اور جدید فلسفیوں کو پڑھنا اچھا لگتا ہے۔",
                    Id=37,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Learning new things is easier when I understand their value",
                    QuestionUrdu="جب میں ان کی قدر کو سمجھتا ہوں تو نئی چیزیں سیکھنا آسان ہوتا ہے۔",
                    Id=38,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I wonder if there are other forms of intelligent life in the Universe",
                    QuestionUrdu="میں حیران ہوں کہ کیا کائنات میں ذہین زندگی کی دوسری شکلیں بھی ہیں؟",
                    Id=39,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Studying history and ancient culture helps give me perspective",
                    QuestionUrdu="تاریخ اور قدیم ثقافت کا مطالعہ مجھے نقطہ نظر دینے میں مدد کرتا ہے۔",
                    Id=40,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I learn best interacting with others",
                    QuestionUrdu="میں دوسروں کے ساتھ بہترین تعامل سیکھتا ہوں۔",
                    Id=41,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="The more the merrier (jitnay ziyada itna maza)",
                    QuestionUrdu="(جتنے زیادہ مزے دار (جتنے زیاد اتنا مزہ",
                    Id=42,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Study groups are very productive for me",
                    QuestionUrdu="اسٹڈی گروپس میرے لیے بہت نتیجہ خیز ہیں۔",
                    Id=43,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy chat rooms",
                    QuestionUrdu="میں چیٹ رومز سے لطف اندوز ہوتا ہوں۔",
                    Id=44,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Participating in politics is important",
                    QuestionUrdu="سیاست میں حصہ لینا ضروری ہے۔",
                    Id=45,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Television and radio talk shows are enjoyable",
                    QuestionUrdu="ٹیلی ویژن اور ریڈیو ٹاک شوز لطف اندوز ہوتے ہیں۔",
                    Id=46,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I am a \"team player\"",
                    QuestionUrdu="میں ایک \"ٹیم پلیئر\" ہوں",
                    Id=47,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I dislike working alone",
                    QuestionUrdu="میں تنہا کام کرنا پسند نہیں کرتا",
                    Id=48,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Clubs and extracurricular activities are fun",
                    QuestionUrdu="کلب اور غیر نصابی سرگرمیاں تفریحی ہیں۔",
                    Id=49,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I Pay attention to social issues and causes",
                    QuestionUrdu="میں سماجی مسائل اور اسباب پر توجہ دیتا ہوں۔",
                    Id=50,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy making things with my hands",
                    QuestionUrdu="مجھے اپنے ہاتھوں سے چیزیں بنانے میں مزہ آتا ہے۔",
                    Id=51,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Sitting still for long periods of time is difficult for me",
                    QuestionUrdu="لمبے عرصے تک خاموش بیٹھنا میرے لیے مشکل ہے۔",
                    Id=52,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy outdoor games and sports",
                    QuestionUrdu="میں بیرونی کھیلوں اور کھیلوں سے لطف اندوز ہوتا ہوں۔",
                    Id=53,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I value non-verbal communication such as sign language",
                    QuestionUrdu="میں غیر زبانی مواصلات جیسے اشاروں کی زبان کو اہمیت دیتا ہوں۔",
                    Id=54,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="A fit body is important for a fit mind",
                    QuestionUrdu="فٹ دماغ کے لیے فٹ جسم ضروری ہے۔",
                    Id=55,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Arts and crafts are enjoyable pastimes",
                    QuestionUrdu="آرٹس اور دستکاری خوشگوار تفریحی مقامات ہیں۔",
                    Id=56,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Expression through dance is beautiful",
                    QuestionUrdu="رقص کے ذریعے اظہار خوبصورت ہے۔",
                    Id=57,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I like working with tools",
                    QuestionUrdu="مجھے ٹولز کے ساتھ کام کرنا پسند ہے۔",
                    Id=58,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I live an active lifestyle",
                    QuestionUrdu="میں ایک فعال طرز زندگی گزارتا ہوں۔",
                    Id=59,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I learn by doing",
                    QuestionUrdu="میں کر کے سیکھتا ہوں۔",
                    Id=60,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy reading all kinds of materials",
                    QuestionUrdu="مجھے ہر قسم کا مواد پڑھ کر لطف آتا ہے۔",
                    Id=61,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Taking notes helps me remember and understand",
                    QuestionUrdu="نوٹ لینے سے مجھے یاد رکھنے اور سمجھنے میں مدد ملتی ہے۔",
                    Id=62,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I faithfully contact friends through letters and/or e-mail",
                    QuestionUrdu="میں وفاداری سے دوستوں سے خطوط اور/یا ای میل کے ذریعے رابطہ کرتا ہوں۔",
                    Id=63,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="It is easy for me to explain my ideas to others",
                    QuestionUrdu="دوسروں کو اپنے خیالات کی وضاحت کرنا میرے لیے آسان ہے۔",
                    Id=64,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I keep a journal",
                    QuestionUrdu="میں ایک جریدہ رکھتا ہوں۔",
                    Id=65,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Word puzzles like crosswords and jumbles are fun",
                    QuestionUrdu="لفظی پہیلیاں جیسے کراس ورڈز اور گڑبڑ مزے کے ہیں۔",
                    Id=66,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I write for pleasure",
                    QuestionUrdu="میں خوشی کے لیے لکھتا ہوں۔",
                    Id=67,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy playing with words like puns, anagrams and spoonerisms (alfaz kay khail)",
                    QuestionUrdu="مجھے puns، anagrams اور spoonisms جیسے الفاظ کے ساتھ کھیلنے میں مزہ آتا ہے (الفاز کے خیل)",
                    Id=68,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Foreign languages interest me",
                    QuestionUrdu="غیر ملکی زبانیں مجھے دلچسپی رکھتی ہیں۔",
                    Id=69,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Debates and public speaking are activities I like to participate in",
                    QuestionUrdu="مباحثے اور عوامی تقریر وہ سرگرمیاں ہیں جن میں میں حصہ لینا پسند کرتا ہوں۔",
                    Id=70,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I am keenly aware of my moral beliefs",
                    QuestionUrdu="میں اپنے اخلاقی عقائد سے بخوبی واقف ہوں۔",
                    Id=71,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I learn best when I have an emotional attachment to the subject",
                    QuestionUrdu="جب میں موضوع سے جذباتی لگاؤ ​​رکھتا ہوں تو میں بہترین سیکھتا ہوں۔",
                    Id=72,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Fairness is important to me",
                    QuestionUrdu="انصاف میرے لیے اہم ہے۔",
                    Id=73,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="My attitude effects how I learn",
                    QuestionUrdu="میرا رویہ اثر کرتا ہے کہ میں کیسے سیکھتا ہوں۔",
                    Id=74,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Social justice issues concern me",
                    QuestionUrdu="سماجی انصاف کے مسائل مجھے فکر مند ہیں۔",
                    Id=75,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Working alone can be just as productive as working in a group",
                    QuestionUrdu="اکیلے کام کرنا اتنا ہی نتیجہ خیز ہوسکتا ہے جتنا کہ کسی گروپ میں کام کرنا",
                    Id=76,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I need to know why I should do something before I agree to do ",
                    QuestionUrdu="مجھے یہ جاننے کی ضرورت ہے کہ مجھے کچھ کرنے پر راضی ہونے سے پہلے مجھے کیوں کرنا چاہیے۔",
                    Id=77,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="When I believe in something I will give 100% effort to it",
                    QuestionUrdu="جب میں کسی چیز پر یقین رکھتا ہوں تو میں اس کے لیے 100% کوشش کروں گا۔",
                    Id=78,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I like to be involved in causes that help others",
                    QuestionUrdu="مجھے ان وجوہات میں شامل ہونا پسند ہے جو دوسروں کی مدد کرتے ہیں۔",
                    Id=79,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I am willing to protest or sign a petition to right a wrong",
                    QuestionUrdu="میں احتجاج کرنے یا غلط کو درست کرنے کے لیے پٹیشن پر دستخط کرنے کو تیار ہوں۔",
                    Id=80,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I can imagine ideas in my mind ",
                    QuestionUrdu="میں اپنے ذہن میں خیالات کا تصور کر سکتا ہوں۔",
                    Id=81,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Rearranging a room is fun for me",
                    QuestionUrdu="ایک کمرے کو دوبارہ ترتیب دینا میرے لئے تفریحی ہے۔",
                    Id=82,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I enjoy creating art using varied media",
                    QuestionUrdu="میں مختلف میڈیا کا استعمال کرتے ہوئے آرٹ تخلیق کرنے سے لطف اندوز ہوتا ہوں۔",
                    Id=83,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I remember well using graphic organizers",
                    QuestionUrdu="مجھے گرافک آرگنائزرز کا استعمال اچھی طرح یاد ہے۔",
                    Id=84,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Performance art can be very gratifying",
                    QuestionUrdu="پرفارمنس آرٹ بہت خوش کن ہوسکتا ہے۔",
                    Id=85,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Spreadsheets are great for making charts, graphs and tables ",
                    QuestionUrdu="اسپریڈ شیٹس چارٹ، گراف اور میزیں بنانے کے لیے بہترین ہیں۔",
                    Id=86,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Three dimensional puzzles bring me much enjoyment",
                    QuestionUrdu="تین جہتی پہیلیاں مجھے بہت لطف دیتی ہیں۔",
                    Id=87,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="Music videos are very stimulating",
                    QuestionUrdu="میوزک ویڈیوز بہت حوصلہ افزا ہیں۔",
                    Id=88,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I can recall things in mental pictures",
                    QuestionUrdu="میں ذہنی تصویروں میں چیزیں یاد کر سکتا ہوں۔",
                    Id=89,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
                new QuestionsModel
                {
                    QuestionDetail="I am good at reading maps and blueprints",
                    QuestionUrdu="میں نقشے اور بلیو پرنٹ پڑھنے میں اچھا ہوں۔",
                    Id=90,
                    choice=new List<string>{"Yes","No"},
                    Score=0
                },
            };
            return questions;
        }
    }
}
