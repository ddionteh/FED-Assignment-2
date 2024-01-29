body {
    margin: 0;
    padding: 0;
    font-family: 'Arial', sans-serif;
}

.hotbar {
    position: relative;
    z-index: 2;
    background: url('https://png.pngtree.com/thumb_back/fh260/background/20200731/pngtree-blue-carbon-background-with-sport-style-and-golden-light-image_371487.jpg') no-repeat;
    background-size: cover;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 15px 20px;
    color: #fff;
}
.hotbar button {
    background: transparent;
    border: none;
    cursor: pointer;
}
.hotbar img {
    width: 80px; /* Adjust the size as needed */
    height: 80px; /* Adjust the size as needed */
}


.logo {
    width: 50px;
    height: 50px;
}

.categories {
    position: relative;
}

.categories span {
    cursor: pointer;
}

.dropdown {
    display: none;
    position: absolute;
    top: 100%;
    left: 0;
    background-color: #fff;
    padding: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    transition: display 5s ease; /* Adjust the duration as needed */
    z-index: 3;
}

.categories .dropdown {
    display: none;
    position: absolute;
    top: 100%;
    left: 0;
    background-color: #fff;
    padding: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    transition: display 5s ease; /* Adjust the duration as needed */
    z-index: 3;
    margin-top: 5px; /* Adjust the margin-top to move it closer */
}
.categories .dropdown a {
    display: block;
    padding: 10px 15px;
    color: #333;
    text-decoration: none;
    transition: background-color 0.3s ease;
}

.categories .dropdown a:hover {
    background-color: #9e9e9e;
    color: #555; /* Change the color on hover if needed */
}

.categories:hover .dropdown {
    display: block;
}

.search-bar {
    padding: 5px;
    margin: 0 10px;
}

.chatbot-icon, .redeem-icon, .cart-icon, .account-icon {
    background: transparent;
    border: none;
    color: #ffffff;
    cursor: pointer;
    margin: 0 5px;
    font-size: 25px;
}

.background-image {
    position: relative;
    z-index: 1;
    background: url('https://png.pngtree.com/thumb_back/fh260/background/20200731/pngtree-blue-carbon-background-with-sport-style-and-golden-light-image_371487.jpg') no-repeat;
    background-size: cover;
    height: 700px; /* Adjust as needed */
}
