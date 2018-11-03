document.addEventListener("DOMContentLoaded", (event) => {
    refreshComments();
    const saveComment = document.querySelector('#save-comment');
    saveComment.addEventListener('click', createComment);
    refreshTags();
    const saveTag = document.querySelector('#save-tag');
    saveTag.addEventListener('click', createTag);
});

function createComment() {
    const commentInput = document.querySelector('#new-comment');
    const newCommentText = document.querySelector('#new-comment').value;
    const newComment = {
        text: newCommentText,
        reviewId: reviewId
    };

    fetch('/Api/Comments', {
        method: 'POST',
        body: JSON.stringify(newComment), 
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        }
    }).then(() => {
        commentInput.value = '';
        refreshComments();
    });
}
function createTag() {
    const tagInput = document.querySelector('#new-tag');
    const newTagText = document.querySelector('#new-tag').value;
    const newTag = {
        text: newTagText,
        reviewId: reviewId
    };

    fetch('/Api/Tags', {
        method: 'POST',
        body: JSON.stringify(newTag),
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        }
    }).then(() => {
        tagInput.value = '';
        refreshTags();
    });
}


function refreshComments() {
    const ol = document.querySelector('#comment-list');
    ol.innerHTML = '';
    fetch(`/api/comments/${reviewId}`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            data.forEach(c => addCommentToDom(c));
        });
}

function refreshTags() {
    const ul = document.querySelector('#tag-list');
    ul.innerHTML = '';
    fetch(`/api/tags/${reviewId}`)
        .then(response => console.log(response.status))
//        .then(res => res.json())
//        .then(data => {
//            console.log(data);
//            data.forEach(c => addTagToDom(c));
//        });
}

function addCommentToDom(comment) {
    const li = document.createElement('li');
    const date = new Date(comment.createdAt);

    li.innerHTML = `${comment.text} <div>${date.toDateString()}</div>`;
    const ol = document.querySelector('#comment-list');
    ol.appendChild(li);
}

function addTagToDom(tag) {
    const li = document.createElement('li');
    console.log(tag);
    const ul = document.querySelector('#tag-list');
    ul.appendChild(li);
}