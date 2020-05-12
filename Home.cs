/* GENERAL */

body {
    background-image: url(https://wallpapercave.com/wp/wp2856269.gif);
    background-size: cover;
    background-color: rgb(5, 8, 10);
    color: rgb(11, 252, 140);
}

.effect {
    display: none;
    opacity: 0;
    padding: 1px;
    font-size: 20px;
    position: fixed;
    bottom: 20%;
    left: 80%;
  }

/* MENU */

#Home-button {
    text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(241, 7, 7);
    position: sticky;
    width: 250px;
    height: 55px;
    font-size: 40px;
    margin: 3px;
    border: 3px solid rgb(0, 255, 136);
    background-color: rgb(0, 0, 0);
}

#Works-button {
    text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(0, 225, 255);
    position: sticky;
    width: 200px;
    height: 55px;
    font-size: 38px;
    margin: 3px;
    border: 3px solid rgb(0, 255, 136);
    background-color: rgb(0, 0, 0);
}

#Bio-button {
    text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(253, 206, 51);
    position: sticky;
    width: 150px;
    height: 55px;
    font-size: 36px;
    margin: 3px;
    border: 3px solid rgb(0, 255, 136);
    background-color: rgb(0, 0, 0);
}

/* ABOUT */

#Bio-space {
    position: fixed;
    top: 75px;
    left: 380px;
    width: 500px;
    height: 500px;
    background-color: #574F7D;
}

#Bio-text-1 {
    position: fixed;
    top: 100px;
    left: 610px;
    font-family: 'Simonetta', 'Sans-Serif';
    font-weight: 900;
    color: #12081A;
}

#Bio-text-2 {
    position: fixed;
    width: 400px;
    top: 150px;
    left: 445px;
    font-family: 'Simonetta', 'Sans-Serif';
    font-weight: 400;
    color: #12081A;
}

#Bio-photo-1 {
    position: sticky;
    align-self: center;
    top: 30%;
    left:50%;
}

#Bio-photo-2 {
    position: fixed;
    align-self: center;
    left: 100px;
    bottom: 10px;
    z-index: -1;
}

#Bio-photo-3 {
    position: fixed;
    align-self: center;
    right: 100px;
    bottom: 10px;
    z-index: -1;
}

#Info-button {

    margin-left: 30%;
}

.modal {
    display: none;
    opacity: 0;
  }


  .modal-popout {
    background: rgb(36, 33, 33);
    border: 2px solid rgb(0, 24, 245);
    padding: 30px;
    
    position: absolute;
    top: 50%;
    left: 50%;
    height: 650px;
    width: 800x;
    transform: translate(-50%, -50%);
  }
  
  .modal-close {
    position: absolute;
    top: 10px;
    right: 10px;
    transform: rotate(45deg);
  }
  
  .modal-close:hover {
    cursor: pointer;
  }
  
  .modal-background {
    background-color: rgba(0, 0, 0, 0.5);
    width: 100%;
    height: 100%;
    position: absolute;
    top: 0;
    left: 0;
  }

/* ASSIGNMENTS */

#a1-link {
      text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(7, 241, 151);
    position: fixed;
    width: 250px;
    height: 55px;
    top: 40px;
    right: 30px;
    font-size: 28px;
    margin: 3px;
    border: 2px solid rgb(0, 89, 255);
    background-color: rgb(0, 0, 0);
}

#a2-link {
      text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(7, 241, 151);
    position: fixed;
    width: 250px;
    height: 55px;
    top: 110px;
    right: 30px;
    font-size: 28px;
    margin: 3px;
    border: 2px solid rgb(0, 89, 255);
    background-color: rgb(0, 0, 0);
}

#a3-link {
      text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(7, 241, 143);
    position: fixed;
    width: 250px;
    height: 55px;
    top: 180px;
    right: 30px;
    font-size: 28px;
    margin: 3px;
    border: 2px solid rgb(0, 89, 255);
    background-color: rgb(0, 0, 0);
}

#a4-link {
        text-align: center;
    font-family: 'Simonetta', 'San-Serif';
    color: rgb(7, 241, 104);
    position: fixed;
    width: 250px;
    height: 55px;
    top: 250px;
    right: 30px;
    font-size: 28px;
    margin: 3px;
    border: 2px solid rgb(0, 89, 255);
    background-color: rgb(0, 0, 0);
}

* {
    margin: 0;
    padding: 0;
 }
 
 
 #Works1 {
    position: absolute;
    animation-name: Works1-animate;
    animation-duration: 8s;
    animation-iteration-count: infinite;
    animation-fill-mode: forwards;
    animation-direction: alternate;
    animation-timing-function: ease-in-out;
 }
 
 #Works2 {
    position: absolute;
    animation-name: Works2-animate;
    animation-duration: 8s;
    animation-iteration-count: infinite;
    animation-fill-mode: forwards;
    animation-direction: alternate-reverse;
    animation-timing-function: linear;
 }
 
 #Works3 {
    position: absolute;
    animation-name: Works3-animate;
    animation-duration: 8s;
    animation-iteration-count: infinite;
    animation-fill-mode: forwards;
    animation-direction: alternate;
    animation-timing-function: linear;
 }

 #Works4 {
    position: absolute;
    animation-name: Works4-animate;
    animation-duration: 8s;
    animation-iteration-count: infinite;
    animation-fill-mode: backwards;
    animation-direction: alternate-reverse;
    animation-timing-function: linear;
 }
 
 @keyframes Works1-animate{
    0%{
       transform: translate(400px, 200px);
    }
    50%{
       transform: translate(500px, 100px);
    }
    100%{
       transform: translate(150px, 600px);
    }
 }
 
 @keyframes Works2-animate{
    0%{
       transform: translate(15px, 511px);
    }
    20%{
       transform: translate(300px, 100px);
    }
    80%{
       transform: translate(900px, 311px);
    }
    100%{
       transform: translate(150px, 444px);
    }
 }
 
 @keyframes Works3-animate{
    0%{
       transform: translate(99px, 22px);
    }
    44%{
       transform: translate(1px, 33px);
    }
    90%{
       transform: translate(444px, 88px);
    }
    100%{
       transform: translate(799px, 511px);
    }
 }

 @keyframes Works4-animate{
    0%{
       transform: translate(250px, 600px);
    }
    44%{
       transform: translate(515px, 600px);
    }
    90%{
       transform: translate(88px, 444px);
    }
    100%{
       transform: translate(420px, 68px);
    }
 }


 .callout-title {
    animation: heartBeat;
    animation-duration: 3s; 
  }
  .callout-subtitle {
 animation: swing;
 animation-duration: 3s; 
}
  .callout {
    grid-area: callout;
    align-self: center;
    justify-self: center;
  
    text-align: center;
  }
  
  .callout-title {
    margin-bottom: 0;

    animation-delay: 0.5s;  
    
    font-size: 4rem;
    font-size: min(14vw, 4rem);
  }


