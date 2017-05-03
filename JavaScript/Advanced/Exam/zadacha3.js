class MailBox {
    constructor(subject, text) {
        this.messages = [];
        this._messageCount = 0;
    }
    addMessage(subject, text) {
        let message = { subject: subject, text: text };
        this.messages.push(message);
        this._messageCount++;
        return this;
    }
    get messageCount() {
        return this._messageCount;
    }
    deleteAllMessages() {
        this.messages = [];
        this._messageCount = 0;
    }

    findBySubject(substr) {
        return this.messages.filter(m => m.subject.indexOf(substr) != -1 && substr != "");
    }

    toString() {
        let result = '';
        for (let obj of this.messages) {
            result += ` * [${obj.subject}] ${obj.text}\n`;
        }
        if (result == '')
            result = " * (empty mailbox)";
        return result;
    }
}
/*
let mb = new MailBox();
console.log("Msg count: " + mb.messageCount);
console.log('Messages:\n' + mb);
mb.addMessage("meeting", "Let's meet at 17/11");
mb.addMessage("beer", "Wanna drink beer tomorrow?");
mb.addMessage("question", "How to solve this problem?");
mb.addMessage("Sofia next week", "I am in Sofia next week.");
console.log("Msg count: " + mb.messageCount);
console.log('Messages:\n' + mb);
console.log("Messages holding 'rakiya': " +
    JSON.stringify(mb.findBySubject('rakiya')));
console.log("Messages holding 'ee': " +
    JSON.stringify(mb.findBySubject('ee')));

mb.deleteAllMessages();
console.log("Msg count: " + mb.messageCount);
console.log('Messages:\n' + mb);

console.log("New mailbox:\n" +
    new MailBox()
        .addMessage("Subj 1", "Msg 1")
        .addMessage("Subj 2", "Msg 2")
        .addMessage("Subj 3", "Msg 3")
        .toString());
*/


