using AustenNovels.Models;

namespace AustenNovels.Controllers
{
    public class NovelInfo
    {
        public NovelInfo()
        {
            Initialize();
        }
        private void Initialize()
        {
            Books novel1 = new Books();
            novel1.Title = ("Sense and Sensibility");
            novel1.PublishedYear = (1811);
            novel1.Characters = ("Elinor Dashwood, Marianne Dashwood, Edward Ferrars, Colonel Christopher Brandon, John Willoughby, Mrs. Jennings, Lucy Steele");
            novel1.Summary = ("Sisters Elinor and Marianne Dashwood along with their mother and younger sister find themselves borderline penniless and homeless once their father dies.  His estate is left to his first wife's son instead." +
                    "A relative provides a cottage away from what they know for the family to move into.  As the sister begin settling into their new lives they learn about love, happiness, and life.");

            Books novel2 = new Books();
            novel2.Title = ("Pride and Prejudice");
            novel2.PublishedYear = (1813);
            novel2.Characters = ("Fitzwilliam Darcy, Elizabeth Bennet, Charles Bingley, Jane Bennet, Caroline Bingley, George Wickham, Lydia Bennet, Mr. Bennet, Mrs. Bennet");
            novel2.Summary = ("Eilizabeth Bennet's first impression of Fitzwilliam Darcy is an arrogant and snob of a man.  However, as Darcy becomes more acquainted with Elizabeth he begins to fall for her wit and intelligence." +
                    "Between false accusations and possible scandal, Elizabeth's wonders if her first impressions were too harsh.  " +
                    "Has her pride gotten in the way of her true feelings for Darcy?  Is it too late to tell Darcy how she really feels?");

            Books novel3 = new Books();
            novel3.Title = ("Mansfield Park");
            novel3.PublishedYear = (1814);
            novel3.Characters = ("Fanny Price, Edmund Bertram, Mary Crawford, Henry Crawford");
            novel3.Summary = ("Fanny Price was ten years old when she moved from poverty to live with her wealthy aunt and cousins at Mansfield Park. Allowed to not forget her humble beginnings, Fanny does not have allies at Mansfield Park outside her cousin, Edmund." +
                    "Henry and Mary Crawford arrive in the neighborhood from London and stir a series of acts that lead to scandal and heartbreak." +
                    "During this period, will Fanny stand her ground and protect her heart for Edmund?");

            Books novel4 = new Books();
            novel4.Title = ("Emma");
            novel4.PublishedYear = (1815);
            novel4.Characters = ("Emma Woodhouse, George Knightley, Harriet Smith, Frank Churchill, Jane Fairfax");
            novel4.Summary = ("Emma Woodhouse loves to play match maker when given the opportunity.  Emma is beautiful, witty, aggrogant and believes things will go her way." +
                    "However when her match matching skills begin to fail, will she be able to rise above?  Will she find love herself?");

            Books novel5 = new Books();
            novel5.Title = ("Persuasion");
            novel5.PublishedYear = (1817);
            novel5.Characters = ("Anne Elliot, Captain Frederick Wentworth, Lady Russell, William Elliot, Lousia Musgrove");
            novel5.Summary = ("Anne Elliot is a sweet tempered young woman who is persuaded to end her engagement with Frederick Wentworth over his lack of fortune. " +
                "Eight years later, Captain Wentworth has returned to England rich and successful however has not forgiven Anne.  Anne has since matured and become more independent, and still in love with him." +
                "As Captain Wentworth and Anne Elliot become more and more in each others circles, will their love resurface?");


            Books novel6 = new Books();
            novel6.Title = ("Northanger Abbey");
            novel6.PublishedYear = (1817);
            novel6.Characters = ("Catherine Morland, Henry Tilney, James Morland, Isabella Thorpe, John Thorpe, Eleanor Tilney");
            novel6.Summary = ("Catherine Morland's first journey away from home is to Bath with family friends.  While in Bath she meets Isabella Thorpe amd Henry Tilney." +
                    "This new friendship leads to an invitiatoin to vist the Tilney's home at Northanger Abbey.  While staying with the Tilney's, Catherine learns of their families past and makes some wild accusations." +
                    "Will Catherine and Henry be able to mend their relationship after such false claims? ");

            Books biography = new Books();
            biography.Biography = ("Jane Austen was born on December 16, 1775 in Steventon, Hampshire.  She was the seventh out of eight children to George and Cassandra Austen." +
                "Jane was sent to boarding school at the age of eight to receive her formal education.  Any education after boarding school was due to her father's library and teachings from her silbings." +
                "She began writing from an early age which was encouraged by her family.  They would frequently write stories and plays and act out for one another." +
                "Jane began writing the early versions of Sense and Sensibility along with Pride and Prejudice even though they would not be formally published for many years. " +
                "When Jane was thirty three when she moved to Chawton Cottage which was a cottage on one of her brother's property.  Here is where she flurished and produced the majority of her novels. " +
                "Sense and Sensibility was published in 1811.  Pride and Prejudice was published in 1813 quickly followed by Mansfield Park in 1814.  The last novel to be published while Austen was alive was Emma in 1815." +
                "Austen had wrote in secret, so all of her novels were By a Lady.  Her last two completed novels were Persuasion and Northanger Abbey, and were published in 1817 after her death." +
                "Jane Austen died on July 18, 1817.  Her health had begin to deterioate in 1816, but she ingnored the symptoms.  By April of 1817 she was confined to a bed." +
                "After her death, her brother Henry unvieled Jane's name and connected her to her novels for the first time.  Her novels have continued to be popular as time goes on, and is considered one of the greatest authors.");

            List<Books> NovelInfo = new List<Books>();
            NovelInfo.Add(novel1);
            NovelInfo.Add(novel2);
            NovelInfo.Add(novel3);
            NovelInfo.Add(novel4);
            NovelInfo.Add(novel5);
            NovelInfo.Add(novel6);
            NovelInfo.Add(biography);

        }
        public List<string> GetNovelInfo()
        {
            return this.Select(NovelInfo => Books.Title).Distinct().OrderedBy(x => x).ToList();
        }
        public List<NovelInfo> GetNovelInfoPublishedYear(int year = default);
    }
}
