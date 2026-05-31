using System;

class Program
{
    static void Main(string[] args)
    {
        //Create the list of videos
        List<Video> videos = new List<Video>();

        //Creating the first Video(video1)
        Video video1 = new Video();
        video1._title = "I will walk with Jesus";
        video1._author = "The Church Of Jesus Christ Of Laterday Saints";
        video1._length = 260;

        //Creating comments for the video1
        Comment comment1 = new Comment();
        comment1._personName = "Christian ISHIMWE";
        comment1._text = "Since I was Baptised, this song was my favorite song and it helps me to come closer to Christ.";
        Comment comment2 = new Comment();
        comment2._personName = "David MBAYINEA";
        comment2._text = "I listen to this every morning.  It helps me get through the rest of the day.";

        Comment comment3 = new Comment();
        comment3._personName = "James Frank";
        comment3._text = "This song gives strength and confidence in me. i love my Savior Jesus Christ.";
        Comment comment4 = new Comment();
        comment4._personName = "Jeremy IRANZI";
        comment4._text = "What a beautiful tribute to our wonderful prophet. He is a true inspiration and the Spirit confirms his words are truth.";

        //Adding the comments to the in the video1
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);

        //Add the video1 to the list
        videos.Add(video1);

        //Creating the second video(video2)
        Video video2 = new Video();
        video2._title = "Above All";
        video2._author = "Micheal W. Smith";
        video2._length = 303;

        //Creating comment for the video2
        Comment comment5 = new Comment();
        comment5._personName = "Mary JOHANA";
        comment5._text = "The words in this song are so true and beautiful, and he sang it well done 👏 thank u for sharing. I love this song.";
        Comment comment6 = new Comment();
        comment6._personName = "Sylvia MASHIGHADI";
        comment6._text = "Above all things Jesus you died for my sins i lift your name on high ooh lord let my heart worship you.";

        Comment comment7 = new Comment();
        comment7._personName = "Claire HOYANA";
        comment7._text = "IT'S INEXPLICABLE THE THAT FEEL WHEN I HEAR THIS BLESSED PRAISE!!";
        Comment comment8 = new Comment();
        comment8._personName = "Kevin MUTUNZI";
        comment8._text = "Thank you Jesus for the greatest love of all. Greater love hath no man than this, that a man lay down his life for his friends.";

        //Adding the comments to the video2
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        video2._comments.Add(comment8);

        //Add the video2 to the list
        videos.Add(video2);

        //Creating the third Video(video3)
        Video video3 = new Video();
        video3._title = "Yeshua";
        video3._author = "Josue Avila";
        video3._length = 600;

        //Creating the comments for the video3
        Comment comment9 = new Comment();
        comment9._personName = "Fahri Namal";
        comment9._text = "I am Turkish and I believe in Jesus. I ask you to pray for my country. Let the kingdom of Jesus come to my country.";
        Comment comment10 = new Comment();
        comment10._personName = "Joseph MUGABO";
        comment10._text = "I love the way us young people are coming to Jesus. I am 15 I received Jesus when I was 14 . We are a generation that Jesus is coming for.";

        Comment comment11 = new Comment();
        comment11._personName = "Marth Laolla";
        comment11._text = "I'm 13 years old, I grew up in a Christian family, I have 9 siblings. And I want to serve God until the end of my life !!!";
        Comment comment12 = new Comment();
        comment12._personName = "Cedric Micheal";
        comment12._text = "I'm Michael from Nigeria.. I gave my life to Christ in 2012 and somehow lost my faith but today God has called me back to his marvelous light to serve him again. Glory be to Jesus Amen.";

        //Adding the comments to the video3
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);
        video3._comments.Add(comment12);

        //Add the video3 to the list
        videos.Add(video3);

        //Creating the forth Video(video4)
        Video video4 = new Video();
        video4._title = "All That Matters";
        video4._author = "Ministry GUC";
        video4._length = 659;

        //Creating comments for video4
        Comment comment13 = new Comment();
        comment13._personName = "Grolia Namanya";
        comment13._text = "Today is my birthday every time someone like this comment I will come back here to listen to this song.";
        Comment comment14 = new Comment();
        comment14._personName = "Promise KAYANGE";
        comment14._text = "I was a drug addict for years, but today I share the gospel. Because He is all in life. Praise God...";

        Comment comment15 = new Comment();
        comment15._personName = "Martin Machevele";
        comment15._text = "I'm 23 years with kidney problem but this song is strengthening me. May God visit me, He is my only hope right now.";
        Comment comment16 = new Comment();
        comment16._personName = "Keria Bridgite";
        comment16._text = "My son turned 27 on the 15th. We were told that he wouldn't make it to 5. But God had another plan for him Thank you Father for you Mercy and Grace.";

        //Adding the comments to the video4
        video4._comments.Add(comment13);
        video4._comments.Add(comment14);
        video4._comments.Add(comment15);
        video4._comments.Add(comment16);

        //Add the video4 to the video list
        videos.Add(video4);

        //Iterate the video list and display the results.
        foreach(Video video in videos)
        {
            Console.WriteLine($"Video title: {video._title}.");
            Console.WriteLine($"Video author: {video._author}.");
            Console.WriteLine($"Video length: {video._length} seconds.");
            Console.WriteLine($"Video comments: {video.DisplayNumberOfComments()} comments.");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                string name = comment._personName;
                string text = comment._text;
                Console.WriteLine($"{name}: {text}");
            }
            Console.WriteLine("\n");
        }
    }
}