function vacantionPrice(countOfGroup, typeOfGroup, day){
    let total = 0;
    switch(typeOfGroup){
        case'Students':
        switch(day){
            case'Friday':
            total = countOfGroup * 8.45;
            if(countOfGroup >= 30){         
                total *=0.85;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Saturday':
             total = countOfGroup * 9.80;
            if(countOfGroup >= 30){         
                total *=0.85;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            } 
            break;
            case'Sunday':
             total = countOfGroup * 10.46;
            if(countOfGroup >= 30){         
                total *=0.85;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
        }
        break;
        case'Business':
        switch(day){
            case'Friday':
            total = countOfGroup * 10.9;
            if(countOfGroup >= 100){         
                total -= 109;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Saturday':
             total = countOfGroup * 15.60;
            if(countOfGroup >= 100){         
                total -= 156;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Sunday':
             total = countOfGroup * 16;
            if(countOfGroup >= 100){         
                total -= 160;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
        }
        break;
        case'Regular':
        switch(day){
            case'Friday':
            total = countOfGroup * 15;
            if(countOfGroup >= 10 && countOfGroup <= 20){         
                total *= 0.95;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Saturday':
             total = countOfGroup * 20;
            if(countOfGroup >= 10 && countOfGroup <= 20){         
                total *= 0.95;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Sunday':
             total = countOfGroup * 22.5;
            if(countOfGroup >= 10 && countOfGroup <= 20){         
                total *= 0.95;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
        }
        break; 
    }
}
