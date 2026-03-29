document.getElementById('scheduleForm').addEventListener('submit', function (event) {
    event.preventDefault();


    const submitButton = event.target.querySelector('button'); //function for the submission button
    const messageDiv = document.getElementById('successMessage'); //

    //loading the response message, if all the fields are full the response starting loading then show a prompt saying it is successful
    submitButton.disabled = true;
    submitButton.innerText = "Scheduling Appointment..."; //loading the response message (should be a spinning icon), it could take a while  


    const formData = new FormData(this);

    fetch('WebForm.aspx/ScheduleAppointment', { //fetching response methods from the php file, these methods are responses after filling in events, date and time and will 'echo' a reponse based on them
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ //converting the whole input to a string,(important for the return statement in the webform.aspx.cs file)
            eventName: document.getElementById('event').value,
            date: document.getElementById('date').value,
            time: document.getElementById('time').value,
            email: document.getElementById('email').value
        })
    })

    .then(response => response.json())
    .then(data => {

        const serverMessage = data.d;

        messageDiv.style.display = 'block'; //displaying the success message 
        messageDiv.innerText = serverMessage;   

        if (data.d.toLowerCase().includes("success")) { //when all fields have been filled the website will return the message
                messageDiv.style.backgroundColor = "#d4edda"; //background color (slightly green) same with css colors must be hexidecimal
                messageDiv.style.color = "#155724"; //border color will be a slightly green color
                document.getElementById('scheduleForm').reset();
        }
        else {
                messageDiv.style.backgroundColor = "#f8d7da"; //red rbackground
                messageDiv.style.color = "#721c24"; //the error message will be a darker red texzt
            }

        })

        .catch(error => { //error handling in case an input is missing or incorrect
            messageDiv.style.display = 'block';
            messageDiv.innerText = "Something went wrong. Please try another input.";
            messageDiv.style.color = "#721c24";
            console.error('Error:', error);
        })
        .finally(() => { //reset button it can run regardless if the input successful or not and makes sure its not stuck 
                         //
            submitButton.disabled = false;
            submitButton.innerText = "Schedule Appointment";
        });

});