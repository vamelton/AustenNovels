using System.Collections.Generic;

namespace AustenNovels.Models
{
    public class NovelInfo 
{
    public NovelInfo ()
    {
Initialize ();
    }
    private void Initialize()
    {
        Books novel1 = new Books();
        novel1.Title =("Sense and Sensibility");
        novel1.PublishedYear =(1811);
        novel1.Characters =("Elinor Dashwood, Marianne Dashwood, Edward Ferrars, Colonel Christopher Brandon, John Willoughby, Mrs. Jennings, Lucy Steele");
        novel1.Summary = ("");

        Books novel2 = new Books();
        novel2.Title =("Pride and Prejudice");
        novel2.PublishedYear =(1813);
        novel2.Characters =("Fitzwilliam Darcy, Elizabeth Bennet, Charles Bingley, Jane Bennet, Caroline Bingley, George Wickham, Lydia Bennet, Mr. Bennet, Mrs. Bennet");
        novel2.Summary =("");

        Books novel3 = new Books();
        novel3.Title =("Mansfield Park");
        novel3.PublishedYear =(1814);
        novel3.Characters =("Fanny Price, Edmund Bertram, Mary Crawford, Henry Crawford");
        novel3.Summary =("");

        Books novel4 = new Books();
        novel4.Title =("Emma");
        novel4.PublishedYear =(1815);
        novel4.Characters =("Emma Woodhouse, George Knightley, Harriet Smith, Frank Churchill, Jane Fairfax");
        novel4.Summary =("");

        Books novel5 = new Books();
        novel5.Title =("Persuasion");
        novel5.PublishedYear = (1817);
        novel5.Characters =("Anne Elliot, Captain Frederick Wentworth, Lady Russell, William Elliot, Lousia Musgrove");
        novel5.Summary = ("");

        Books novel6 = new Books();
        novel6.Title =("Northanger Abbey");
        novel6.PublishedYear =(1817);
        novel6.Characters =("Catherine Morland, Henry Tilney, James Morland, Isabella Thorpe, John Thorpe, Eleanor Tilney");
        novel6.Summary =("");

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
