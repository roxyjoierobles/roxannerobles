h1 {
  text-align: center;
  font-family: "Sail", cursive;
  font-size: 65px;
  color: white;
  line-height: 65px;
}

#header {  
  background-image: url("https://i.pinimg.com/564x/d4/65/22/d46522cf4396730b54cb1d838b76e093.jpg"); 
  height: 70px;
  margin: 0px; 
}

#header:hover {
  -webkit-animation:imageRoll 15s infinite linear;
  background-repeat: no-repeat;
  background-size: cover;
}

@-webkit-keyframes imageRoll {
  0% {
   background-image: url("https://i.pinimg.com/564x/ba/c0/23/bac02379eeb5030fc8c4548e4a142b96.jpg");
  } 
  50% {
     background-image: url("https://i.pinimg.com/564x/ba/c0/23/bac02379eeb5030fc8c4548e4a142b96.jpg");
  }
}

/** multipage design */
#main {
  padding 10px;
}
input[name="pages"] {
  display: none;
}
section.page {
  position: relative;
  display: none;
}
input[name = "pages"]:checked+section.page {
  display: block;
}
label.label-link {
  color: black;
  text-decoration: none;
  cursor: pointer;
  padding: 5px;
  font-family: "Playfair Display";
  font-size: 15px;
}

body {
  text-align: center;
}

#footer { 
  text-align: center;
  height: 100px; 
  width:100%;
  bottom: 0; 
  position: relative;
}

h2 {
  font-family: "Meddon";
  color: pink;
  font-size: 30px;
}
h3 {
  font-family: "Playfair Display";
  font-size: 16px;
}

ul.projects { 
  list-style-type: circle;
  list-style-position: inside;
  text-align: center;
}

ul.projects li a {
  text-align: center;
  color: black;
  text-decoration: none;
}

ul.hi {
  margin: 0;
  padding: 0;
}

ul.hi li { 
  color: black;
  list-style-type: circle;
  list-style-position: inside;
}

p.a {
  font-family: "Meddon";
  padding: 0;
  margin: 0;
}

/* .fa {
  padding: 20px;
  font-size: 30px;
  width: 50px;
  text-align: center;
  text-decoration: none;
  margin: 5px 2px;
}
.fa:hover {
    opacity: 0.7;
}
.fa-facebook {
  background: #3B5998;
  color: white;
}
.fa-twitter {
  background: #55ACEE;
  color: white;
}
.fa-google {
  background: #dd4b39;
  color: white;
}
.fa-youtube {
  background: #bb0000;
  color: white;
}
.fa-instagram {
  background: #125688;
  color: white;
}
.fa-pinterest {
  background: #cb2027;
  color: white;
} */
