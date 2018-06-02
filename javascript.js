var q = ["She continues to create a world entirely of her own", "You are so much lovelier than you think", "Get lost in what you love", "You are not his princess. You are your own queen", "Do what you can with what you have where you are", 
         "\'I love myself\' the quietest, simplest, most powerful revolution ever.", "You are only human. You don\'t have to have it together every minute of every day.", "Confidence is not \'they will like me\'. Confidence is \'i\'ll be fine if they don\'t\'", 
         "Empowered women empower women", "She believed she could so she did", "Do what you love, love what you do", "Grateful for where I\'m, excited for where I\'m going", "Your value doesn\'t decrease based on somebody\'s inability to see your worth",
         "And at the end of the day, your feet should be dirty, your hairy messy and your eyes sparkling", "If you see something beautiful in someone, speak it", "No act of kindness, no matter how small, is ever wasted", "Veni, vidi, amavi - we came, we saw, we loved.",
         "There is nothing in nature that blooms all year long, so don\'t expect yourself to do so either.", "She turned her can\'ts into cans and dreams into plans", "Better an oops than a what if", "kind words cost nothing", "Don\'t just exist, live", 
         "She had a galaxy in her eyes, a universe in her mind", "if you have good thoughts, they will shine out of your face like sunbeams and you will always look lovely", "with the new day comes new strength and new thoughts",
         "don\'t count the days, make the days count", "surround yourself with the things you love, discard the rest", "inhale confidence, exhale doubt", "nothing can dim the light that shines from within"
        ];

function getQuote() {
  var randomQ = Math.floor(Math.random() * (q.length));
   document.getElementById("quoteDisplay").innerHTML = 
"\"" + q[randomQ] + "\"";
 }
