var url = "https://hr-api.kmc.solutions/api/jobs/active-positions"

fetch(url)
    .then(response => response.json())
    .then(data => showData(data))


function showData(data) {
    var resultDiv = document.getElementById("openPositions")

    for (let index = 0; index < 6; index++) {
        resultDiv.innerHTML += 
        `<div class='col-lg-4 col-md-6 col-sm-12 col-12 mb-3 d-flex align-items-stretch'>
            <div class='card w-100'> 
                <div class='card-body d-flex flex-column'> 
                    <a class='text-dark' style='font-size: 1.2rem; font-family:PROXIMANOVA-EXTRABOLD,Arial,Helvetica,sans-serif' href='/careers/${data[index].url}'>${data[index].position}</a>
                    <p>${data[index].category}<br />
                    <small>${data[index].city}</small></p>
                    <div class='card-link mt-auto'>
                        <a style='font-family:PROXIMANOVA-EXTRABOLD,Arial,Helvetica,sans-serif' href='/careers/${data[index].url}'>Apply Now <i class="fas fa-long-arrow-alt-right"></i></a>
                    </div>
                </div> 
            </div>
        </div>`
    }
}

