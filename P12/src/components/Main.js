import React from 'react';
import './Main.css';

class Main extends React.Component {
    render() {
        return ( <
            div className = "Main" >
            <
            div className = "logo" >
            <
            p >
            <
            img src = "Materials/image (1).png"
            alt = "not found" / >
            <
            /p> <
            /div>

            <
            div className = "photo" >
            <
            img src = "Materials/unsplash_HyXN3uapAVA.png"
            alt = "Not found" / >
            <
            /div>

            <
            div className = "text" >
            <
            p > Make Positive Energy < br / > Around you, < br / > Make yourself Fresh. < /p> <
            /div>

            <
            div className = "grey-button" >
            <
            p >
            <
            a href = "https://yandex.ru/images/search?from=tabbar&text=%D1%86%D0%B2%D0%B5%D1%82%D1%8B%20%D0%B2%20%D0%B1%D1%83%D0%BA%D0%B5%D1%82%D0%B5" >
            <
            img src = "Materials/grey.jpg"
            alt = ""
            width = "120"
            height = "60" / >
            <
            /a> <
            /p> <
            /div>

            <
            div className = "green-button" >
            <
            p >
            <
            a href = "https://lovelybuket.ru/?utm_source=yandex&utm_medium=cpc&utm_campaign=91728604&utm_content=14726296936&utm_term={gender}&utm_term={age}&utm_term=---autotargeting&yclid=16671388340024246271" >
            <
            img src = "Materials/green.jpg"
            alt = ""
            width = "200"
            height = "60" / >
            <
            /a> <
            /p> <
            /div> <
            /div>
        );
    }
}

export default Main;