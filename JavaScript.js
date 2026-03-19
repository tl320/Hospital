document.getElementById('scheduleForm').addEventListener('submit', function (event) {

    event.preventDefault();
    const fomData = new formData(this);

    fetch('schedule.php');
    method: 'POST',
        body; formData

    .then(response => response.txt())
    .then(data => { document.getElementById('message').innerText = data; })
    .catch(Error => { console.error('error', 'error'); })
})