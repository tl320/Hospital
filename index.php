<?php

if ($_SERVER['REQUEST_METHOD'] === ['POST']) { //if loop, a user will interact with the website and will send a request to the server

$event = htmlspecialchars(string: $_POST['event']); // event (in php it is a little vauge it covers resterant reservations, business meetings etc, in this context it's hospital appointments)
$date = htmlspecialchars(string: $_POST['date']);// for date, taking in the full date of the appointment
$time = htmlspecialchars(string: $_POST['time']);//for time (both for AM and PM)

$data = "event: $event \nDate: $date\nTime: $time\n\n"; // the data will take in three arguments the event (which is the hospital appointment )
file_put_contents(filename: 'events.html', data: $data, flags: FILE_APPEND);
echo "Event has been scheduled Successfully."; 
}else
    {
        echo "Invalid schedule Request"; 
    }


