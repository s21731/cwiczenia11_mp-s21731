var submitionPage;

async function show(id) {
    submitionPage = document.getElementById('submition-' + id);
    submitionPage.style.display = 'block';
}

async function accept() {
    submitionPage.style.display = 'none';
}

async function decline() {
    submitionPage.style.display = 'none';
}