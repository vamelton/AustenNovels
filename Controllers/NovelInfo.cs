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
            novel1.Summary = ("Sisters Elinor and Marianne Dashwood along with their mother and younger sister find themselves borderline penniless and homeless when their father dies.  His estate is left to his first wife's son instead." +
                    "A relative provides a cottage for the family away from what they know.  As the sisters begin settling into their new lives they learn about love, happiness, and life.");

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

          

            List<Books> NovelInfo = new List<Books>();
            NovelInfo.Add(novel1);
            NovelInfo.Add(novel2);
            NovelInfo.Add(novel3);
            NovelInfo.Add(novel4);
            NovelInfo.Add(novel5);
            NovelInfo.Add(novel6);
            

        }
      
    }
}
