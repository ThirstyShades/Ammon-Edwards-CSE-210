// make new instance of a vidio
Vidio vidio1 = new Vidio("Me at the zoo","Jawed", 19);
// Display vidio1
vidio1.DisplayVidio();
// make a new comment
Comment comment1 = new Comment("@SanDiegoZoo", "We're so honored that the first ever YouTube video was filmed here!");
// add that comment to vidio1
vidio1.SetComment(comment1);
// make another comment and add it to vidio one
Comment comment2 = new Comment("@Awesomeness", "The video that LITERALLY started it all");
vidio1.SetComment(comment2);
//Finally list the comments for vidio1
vidio1.ListComments();


// make new instance of a vidio
Vidio vidio2 = new Vidio("Battlebit Remastered HAS to be the wake up call for Battlefield...","BigfryTV", 6*60);
// Display vidio1
vidio2.DisplayVidio();
// make a new comment
Comment comment3 = new Comment("@akaxstretch", "One thing I love is that 2042 can longer use 64v64 as an excuse. It was never really the issue. We have 127v127 with maps that are designed accordingly. The list of excuses are minimal when you have a $15, 3 man team game such as battlebit.");
// add that comment to vidio2
vidio2.SetComment(comment3);
// make another comment and add it to vidio two
Comment comment4 = new Comment("@mohamednail1707", "The fact that the game is made by 3 people and it's more fun and complete then 2042 is both sad and hilarious.");
vidio2.SetComment(comment4);
//Finally list the comments for vidio2
vidio2.ListComments();