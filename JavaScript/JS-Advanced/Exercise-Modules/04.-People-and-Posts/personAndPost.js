/**
 * Created by tangrila on 04-Nov-16.
 */
let solve = function () {
	class Person {
		constructor(name, age) {
			this.name = name;
			this.age = age;
		}

		addToSelector(selector) {
			let html =
				$(`<div class="person ${this.name}">
                        <p class="name">${this.name}</p>
                        <p class="age">${this.age}</p>
                        <div class="posts ${this.name}"></div>
                    </div>`);
			$(selector).append(html);
		}
	}

	class Post {
		constructor(title, body, author) {
			this.title = title;
			this.body = body;
			this.author = author;
		}

		addToSelector(selector) {
			let html =
				$(`<div class="post ${this.author}">
                        <h3 class="title">${this.title}</h3>
                        <p class="body">${this.body}</p>
                        <p class="author">${this.author}</p>
                    </div>`);
			$(selector).append(html);

		}
	}

	return {
		Person,
		Post
	}
}();
module.exports = solve;
/*
 let person = new Person("Pesho", 21);
 let post = new Post('Sample title', 'Sample Body', 'Pesho');
 person.addToSelector('#container');
 post.addToSelector('#container');
 */