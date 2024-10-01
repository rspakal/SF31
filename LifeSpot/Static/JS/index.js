//let session = {
//    'startDate': new Date().toLocaleDateString(),
//    'userAgent': window.navigator.userAgent,
//    'userAge':prompt("Please, enter ur age")
//}


function handleSession(logger, checker) {

    if (window.sessionStorage.getItem("startDate") == null) {
        window.sessionStorage.setItem("startDate", new Date().toLocaleString())
    }

    if (window.sessionStorage.getItem("userAgent") == null) {
        window.sessionStorage.setItem("userAgent", window.navigator.userAgent)
    }

    if (window.sessionStorage.getItem("userAge") == null) {
        let input = prompt("Please, enter ur age?");
        window.sessionStorage.setItem("userAge", input)

        checker(true)
    } else {

        checker(false)
    }
    logger()
}

function filterContent() {
    let elements = document.getElementsByClassName('video-container');

    for (let i = 0; i <= elements.length; i++) {
        let videoText = elements[i].querySelector(".video-title").innerText;
        if (!videoText.toLowerCase().includes(inputParseFunction().toLowerCase())) {
            elements[i].style.display = 'none';
        } else {
            elements[i].style.display = 'inline-block';
        }
    }
}

let checker = function (newVisit) {
    if (window.sessionStorage.getItem("userAge") >= 18) {
        if (newVisit) {
            alert("Welcome to LifeSpot! " + '\n' + "The current date is : " + new Date().toLocaleString());
        }
    }
    else {
        alert("18+ only!");
        window.location.href = "http://www.google.com"
    }
}

let logger = function logSession() {
    alert("!");
    console.log('Session start: ' + window.sessionStorage.getItem("startDate"))
    console.log('Client data: ' + window.sessionStorage.getItem("userAgent"))
    console.log('User age: ' + window.sessionStorage.getItem("userAge"))
}