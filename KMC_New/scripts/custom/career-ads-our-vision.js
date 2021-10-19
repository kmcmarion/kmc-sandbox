var coreValues = [
    {
        title: 'Enhance Everything',
        text: 'We strive to seek constant improvement and growth within ourselves every day, putting in passion and optimism in the work that we do. By enhancing ourselves through our health, mind, and body, we also strive in prioritizing the overall wellness of our inclusive community — welcoming all genders, races, and people from all walks of life.',
        image: '/media/lvcjevrc/astro_landing_1.png',
        navText: '01 Enhance Everything'
    },
    {
        title: "It's Everyone's Problem",
        text: 'We avoid finger-pointing and take accountability as a team, with everyone working towards the common goal of coming up with a solution. This extends outside the office, and helps in creating an environment that fosters both collaboration and compassion with employees and clients, within the community, and our surroundings.',
        image: '/media/3qwlxzna/astro_landing_2.png',
        navText: "02 It's Everyone's Problem"
    },
    {
        title: 'We Eat, Drink, Sleep Flexibility',
        text: 'We are constantly looking for ways to make things easier for our clients, people and other stakeholders. We stay agile, versatile, and think outside the box to come up with the best solutions that help them lead a flexible life.',
        image: '/media/jaojnmtd/astro_landing_3.png',
        navText: '03 We Eat, Drink, Sleep Flexibility'
    },
    {
        title: 'Anticipate the Future',
        text: 'We are continuously anticipating our clients’ future needs to find new ways that ensure they have the best experience with us. By taking chances, we strive to be forward thinking leaders in our industry that continue to create more innovative solutions that make things easier for everybody.',
        image: '/media/5ondzs4o/astro_landing_4.png',
        navText: '04 Anticipate the Future'
    }
]

jQuery(document).ready(function () {
    console.log("Hello")
    var carouselNumber = 0;
    var carouselStart = 0;
    var carouselLimit = 3;

    // Carousel Next Button
    jQuery("#carouselNext").click(function(){
        ( carouselNumber == carouselLimit ? carouselNumber = 0 : carouselNumber++ )

        jQuery(".section-title").text(coreValues[carouselNumber].title);

        jQuery(".section-text").text(coreValues[carouselNumber].text);

        jQuery(".section-image").attr("src", coreValues[carouselNumber].image)

        jQuery(".section-nav a").each(function(j){
            if( jQuery(this).text() == coreValues[carouselNumber].navText )
            {
                jQuery(this).addClass("active-item")
            }
            else
            {
                jQuery(this).removeClass("active-item")
            }
        })
        
    })
    

    // Carousel Previous Button
    jQuery("#carouselPrev").click(function(){
        ( carouselNumber <= carouselStart ? carouselNumber = 3 : carouselNumber-- )
        
        jQuery(".section-title").text(coreValues[carouselNumber].title);

        jQuery(".section-text").text(coreValues[carouselNumber].text);

        jQuery(".section-image").attr("src", coreValues[carouselNumber].image)

        jQuery(".section-nav a").each(function(j){
            if( jQuery(this).text() == coreValues[carouselNumber].navText )
            {
                jQuery(this).addClass("active-item")
            }
            else
            {
                jQuery(this).removeClass("active-item")
            }
        })
    })

    // NAV ONCLICK EVENTS
    $(".nav-item-1").click(() => navClickEvent(0))
    $(".nav-item-2").click(() => navClickEvent(1))
    $(".nav-item-3").click(() => navClickEvent(2))
    $(".nav-item-4").click(() => navClickEvent(3))
})

// FUNCTIONS
function navClickEvent(navNumber) {
    console.log(navNumber)
    $(".section-title").text(coreValues[navNumber].title);

    $(".section-text").text(coreValues[navNumber].text);

    $(".section-image").attr("src", coreValues[navNumber].image)

    $(".section-nav a").each(function (j) {
        if ($(this).text() == coreValues[navNumber].navText) {
            $(this).addClass("active-item")
        }
        else {
            $(this).removeClass("active-item")
        }
    })
}