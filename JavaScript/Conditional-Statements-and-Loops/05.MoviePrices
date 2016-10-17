function moviePrices([title, day]) {
	let movies = [
		{ Title: "the godfather",
			DayPrice: {
				monday: 12,
				tuesday: 10,
				wednesday: 15,
				thursday: 12.50,
				friday: 15,
				saturday: 25,
				sunday: 30
			}
		},
		{ Title: "schindler's list",
			DayPrice: {
				monday: 8.50,
				tuesday: 8.50,
				wednesday: 8.50,
				thursday: 8.50,
				friday: 8.50,
				saturday: 15,
				sunday: 15
			}
		},
		{ Title: "casablanca",
			DayPrice: {
				monday: 8,
				tuesday: 8,
				wednesday: 8,
				thursday: 8,
				friday: 8,
				saturday: 10,
				sunday: 10
			}
		},
		{ Title: "the wizard of oz",
			DayPrice: {
				monday: 10,
				tuesday: 10,
				wednesday: 10,
				thursday: 10,
				friday: 10,
				saturday: 15,
				sunday: 15
			}
		}
	];
	title = title.toLowerCase();
	day = day.toLowerCase();

	let movie = (movies.filter(function(v) {
		return v['Title'] == title;
	}))[0];

	// movie title not found
	if (movie == undefined)
		return "error";

	let price = movie['DayPrice'][day];

	return price != undefined ? price : "error";
};
