const template = document.createElement('template');
template.innerHTML = `
<style>
@import url("https://fonts.googleapis.com/css2?family=Roboto&display=swap");
* {
  box-sizing: border-box;
  font-family: "Roboto", sans-serif;
  margin: 0;
  padding: 0;
}

.labcard {
  overflow: hidden;
  display: flex;
  flex-direction: column;
  width: 225px;
  height: 400px;
  margin: 10px;
  background: #ffffff;
  box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.1);
  border-radius: 10px;
}

.cardhead {
  margin: 10px;
  margin-bottom: 0;
  color: #00bfa5;
  font-weight: bold;
  font-size: 20px;
}

.labcard .item-img {
  width: 100%;
  height: 180px;
  object-fit: cover;
}

.labcard .detail {
  padding: 20px;
}

.labcard .detail .title {
  font-size: 24px;
  color: rgba(38, 50, 56);
}

.labcard .detail .equity {
  font-size: 14px;
  color: rgba(38, 50, 56, 0.6);
}

.labcard .detail .body {
  font-size: 12px;
  color: rgba(38, 50, 56, 0.6);
  overflow: hidden;
  height: 80px;
  margin-top: 10px;
  margin-bottom: 10px;
  overflow-y: scroll;
  /* Hide scrollbar for IE, Edge and Firefox */
  -ms-overflow-style: none; /* IE and Edge */
  scrollbar-width: none; /* Firefox */
}

/* Hide scrollbar for Chrome, Safari and Opera */
.labcard .detail .body::-webkit-scrollbar {
  display: none;
}

.labcard .detail .btn-book {
  background-color: #009688;
  border: none;
  color: #ffffff;
  border-radius: 25px;
  width: 100%;
  height: 30px;
  font-size: 16px;
cursor: pointer;
}

</style>
<div class="cardhead" id="cardhead">Lab1</div>
    <div class="labcard">
        <img class="item-img" src="https://images.unsplash.com/photo-1619345371662-fccc15cc4814?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=976&q=80"/>
        <div class="detail">
            <h3 class="title">Voltmeter</h3>
            <label class="equity">12 pcs</label>
            <p class="body"> UT136B+ automatic range digital multimeter with capacitor, frequency Temperature measurement function (UT136C+ only); Measure AC and DC voltages up to 1000V; Can measure up to 10A (20A when measuring time 30S); The maximum display is 3999; With diode and triode test function; With NCV function (UT136B+ only); Basic functions such as on-off test, data hold, auto power off, low voltage display and screen backlight; Safety grade CAT II 1000V, CAT III 600V, passed the 1m drop test; Full-featured false detection protection, can withstand 1kV voltage shock</p>
            <a href="/Bookingdetail"><button class="btn-book" onclick="location.href='@Url.Action("Index", "Bookingdetail")'">BOOK</button></a>
        </div>
    </div>`
class LabCard extends HTMLElement {
    constructor() {
        super();
        this.attachShadow({ mode: 'open' });
        this.shadowRoot.appendChild(template.content.cloneNode(true));
        this.shadowRoot.getElementById("cardhead").innerText = this.getAttribute('lab');
        this.shadowRoot.querySelector('img').setAttribute('src', this.getAttribute('image'));
        this.shadowRoot.querySelector('p').innerText = this.getAttribute('desc');
        this.shadowRoot.querySelector('label').innerText = this.getAttribute('vol') + " pieces";
        this.shadowRoot.querySelector('h3').innerText = this.getAttribute('itemName');
        this.shadowRoot.querySelector('a').setAttribute('href', "/Bookings?item=" + this.getAttribute('itemName'));
    }
    handleClick() {
        console.log(this.getAttribute('name'))
    }
    connectedCallback() {
        this.shadowRoot.querySelector('button').addEventListener('click', () => this.handleClick());
    }
    discoonnectedCallback() {
        this.shadowRoot.querySelector('button').removeEventListener();
    }

}
customElements.define('lab-card', LabCard);


