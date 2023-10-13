<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bio Data Form</title>
    <link href="./style.css" rel="stylesheet">
</head>

<body>
    <div class="letter">
        <div class="letter-header">
            <h1>Bio Data Form</h1>
            <i>Please complete the information below or submit a resume or vita</i>
        </div>
        <div class="letter-body">
            <div class="row">
                <div class="column">
                    <h4>Name:______________________________________________________________________________________</h4>
                    <h4>Telephone:_________________________________________________________________________________</h4>
                </div>
                <div class="column">
                    <h4>Address:___________________________________________________________________________________</h4>
                    <h4>Email:_____________________________________________________________________________________</h4>
                </div>
            </div>
            <h4>Education:</h4>
            <div class="row">
                <div class="column">
                    <h4>Institution:</h4>
                    <h4>Degree / Certificate Received:</h4>
                    <h4>Area of Study:</h4>
                </div>
                <div class="column">
                    <p class="separator">_____________________________</p>
                    <br>
                    <br>
                    <p class="separator">___________________________</p>
                    <br>
                    <br>
                    <p class="separator">_____________________________</p>  
                </div>
                <div class="column">
                    <p class="separator">______________________________</p>
                    <br> 
                    <br>
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>  
                </div>
                <div class="column">
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>  
                </div>
                <div class="column">
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>  
                </div>
            </div>
            <h4>Employment History:</h4>
            <div class="row">
                <div class="column">
                    <h4>Organization:</h4>
                    <h4>Dates:</h4>
                    <h4>Job Title:</h4>
                </div>
                <div class="column">
                    <p class="separator">1.____________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>   
                </div>
                <div class="column">
                    <p class="separator">2.___________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>  
                </div>
                <div class="column">
                    <p class="separator">3.________________________</p>
                    <br>
                    <br>
                    <p class="separator">___________________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________</p>  
                </div>
                <div class="column">
                    <p class="separator">4._______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>
                    <br>
                    <br>
                    <p class="separator">_______________________</p>  
                </div>
            </div>
            <div class="letter-body">
                <h4>Professional Affiliations, Licenses & Certificates:<i>List all relevant to radiologic technology.</i> </h4>
                <p class="separator">______________________________________________________________________________________________________________________</p>
                <p class="separator">_______________________________________________________________________________________________________________________</p>
                <p class="separator">_________________________________________________________________________________________________________________________</p>
                <h4>Others: <i>Awards, Service, Special Interest</i> </h4>
                <p class="separator">___________________________________________________________________________________________________________________________</p>
                <p class="separator">____________________________________________________________________________________________________________________________</p>
                <p class="separator">___________________________________________________________________________________________________________________________</p>

                <h4>Optional Summary Statement:<i>Highlight strongest skills and area of professional expertise.</i></h4>
                <p class="separator">________________________________________________________________________________________________________________________</p>
                <p class="separator">________________________________________________________________________________________________________________________</p>
                <p class="separator">__________________________________________________________________________________________________________________________</p>
                <div class="letter-body">
                    <footer> Thank you! Please return this form along with the ARRT Exam Development Activity 
                    Preference Form via: email volunteersart.org: fax (651) 681-3298; or mail to ARRT,
                     Att: Psychometric Services, 1255 Northland Dr., St. Paul, MN 55120</footer>


        </div>
        </div>
    </div>
</body>

</html>


css


* {
    box-sizing: border-box;
  }
  
  .separator {
    margin-bottom: 10px;
  }
  
  body {
    font-family: Arial, sans-serif;
    background-color: #f2f2f2;
    margin: 0;
    padding: 0;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
  }
  
  .column {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    width: 100%;
  }
  
  .row:after {
    content: "";
    display: table;
    clear: both;
  }
  
  .letter {
    text-align: left;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
  }
  
  .letter-header {
    text-align: center;
  }
  
  .letter-header h1 {
    font-size: 24px;
  }
  
  .letter-header i {
    font-style: italic;
  }
  
  .letter-body {
    text-align: left;
  }
  
  .letter-body i {
    font-weight: lighter;
    margin: 10px;
  }
  
  .letter-body h4 {
    font-weight: bold;
    margin: 25px;
  }
  .letter-body p {
    font-weight: bold;
    margin: 25px;
  }
