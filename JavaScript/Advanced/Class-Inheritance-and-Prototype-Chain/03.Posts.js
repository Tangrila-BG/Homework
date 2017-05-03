/**
 * Created by tangrila on 03-Nov-16.
 */
function posts () {
	class Post {
		constructor(title, content) {
			this.title = title;
			this.content = content;
		}

		toString() {
			return `Post: ${this.title}\n` +
				`Content: ${this.content}`;
		}
	}

	class SocialMediaPost extends Post {
		constructor(title, content, likes, dislikes) {
			super(title, content);
			this.likes = Number(likes);
			this.dislikes = Number(dislikes);
			if (isNaN(likes)) this.likes = 0;
			if (isNaN(dislikes)) this.dislikes = 0;
			this.comments = [];
		}

		addComment(comment) {
			this.comments.push(comment);
		}

		toString() {
			if (this.comments.length == 0) {
				return `Post: ${this.title}\n` +
					`Content: ${this.content}\n` +
					`Rating: ${this.likes} - ${this.dislikes}\n`
			}
			return `Post: ${this.title}\n` +
				`Content: ${this.content}\n` +
				`Rating: ${this.likes - this.dislikes}\n` +
				`Comments:\n` +
				` * ${this.comments.join("\n * ")}`;

		}

	}

	class BlogPost extends Post {
		constructor(title, content, views) {
			super(title, content);
			this.views = Number(views);
			if (isNaN(views)) this.views = 0;
		}

		view() {
			this.views++;
			return this;
		}

		toString() {
			return `Post: ${this.title}\n` +
				`Content: ${this.content}\n` +
				`Views: ${this.views}`;

		}
	}

	return {
		Post,
		SocialMediaPost,
		BlogPost
	}
}

/*
let tester = new SocialMediaPost("Pesho", "Pesho be");
console.log(tester.toString());
*/

let blogTester = new BlogPost("Sample Title", "Sample Content");
blogTester.view();
console.log(blogTester.toString());