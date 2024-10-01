let currentSlide = 0;

function Comment() {
    this.author = prompt("Whats ur name")
    if (this.author == null) {
        this.empty = true
        return
    }

    this.text = prompt("Leave ur feedback")
    if (this.text == null) {
        this.empty = true
        return
    }
    this.date = new Date().toLocaleString()
}

function addComment() {
    let comment = new Comment()
    if (comment.empty) {
        return;
    }
    let enableLikes = confirm('Let users to rate ur feedback?')

    if (enableLikes) {
        let review = Object.create(comment)
        review.rate = 0;
        writeReview(review)
    } else {
        writeReview(comment)
    }
}
function getComment() {
    let comment = {}
    comment.author = prompt("Whats ur name?")
    if (comment.author == null) {
        return
    }
    comment.text = prompt("Leave ur feedback")
    if (comment.text == null) {
        return
    }
    comment.date = new Date().toLocaleDateString()
    let enableLikes = confirm('Let users to rate ur feedback?')
    if (enableLikes) {
        let review = Object.create(comment)
        review.rate = 0
        writeReview(review)
    } else {
        writeReview(comment)
    }
}

const writeReview = review => {
    let likeCounter = '';
    if (review.hasOwnProperty('rate')) {
        let commentId = Math.random();
        likeCounter += '<button id="' + commentId + '" style="border: none" onclick="addLike(this.id)">' + `&#10084 ${review.rate}</button>`
    }

    document.getElementsByClassName('reviews')[0].innerHTML +=
        '<div class="review-text">\n' +
        `<p><b>${review['author']}</b> ${review['date']} ${likeCounter}</p>` +
        `<p>${review['text']}</p>` +
        '</div>';
}
function getReview() {
    let review = {}
    review["userName"] = prompt("Write ur name")
    if (review["userName"] == null) {
        return
    }

    review["comment"] = prompt("Write ur feedback")
    if (review["comment"] == null) {
        return
    }

    review["date"] = new Date().toLocaleString()

    writeReview(review)
}

function addLike(id) {
    let element = document.getElementById(id);
    let array = element.innerText.split(' ')
    let resultNum = parseInt(array[array.length - 1], 10);
    resultNum += 1
    array[array.length - 1] = `${resultNum}`
    element.innerText = array.join(' ')
}

function moveSlide(direction) {
    const slides = document.querySelector('.slides');
    const totalSlides = document.querySelectorAll('.slide').length;
    currentSlide = (currentSlide + direction + totalSlides) % totalSlides;
    slides.style.transform = `translateX(-${currentSlide * 100}%)`;
    //alert("!");
}
