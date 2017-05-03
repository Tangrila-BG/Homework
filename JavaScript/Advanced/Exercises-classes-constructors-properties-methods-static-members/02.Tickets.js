/**
 * Created by tangrila on 29-Oct-16.
 */

function ticketsTask(ticketsData, sortMethod) {
	let tickets = [];
	class Ticket {
		constructor(destination, price, status) {
			this.destination = destination;
			this.price = price;
			this.status = status;
		}
	}

	ticketsData.forEach(ticketInfo => {
		let [destination, price, status] = ticketInfo.split('|');
		price = Number(price);
		let ticket = new Ticket(destination, price, status);
		tickets.push(ticket);
	});

	switch (sortMethod) {
		case 'destination':
			tickets = tickets.sort((a, b) => {
				if (a.destination == b.destination) return 0;
				return a.destination.localeCompare(b.destination);
			});
			break;
		case 'price':
			tickets = tickets.sort((a, b) => {
				if (a.price === b.price) return 0;
				return a.price - b.price;
			});
			break;
		case 'status':
			tickets = tickets.sort((a, b) => {
				if (a.status == b.status) return 0;
					return a.status.localeCompare(b.status);
			});
			break;
	}
	return tickets;
}

/*
ticketsTask(
	[
		'Philadelphia|94.20|available',
		'New York City|95.99|available',
		'New York City|95.99|sold',
		'Boston|126.20|departed'
	],
	'destination'
);*/
ticketsTask(
	[
		'Philadelphia|94.20|available',
		'New York City|95.99|available',
		'New York City|95.99|sold',
		'Boston|126.20|departed'
	],
	'status'

)