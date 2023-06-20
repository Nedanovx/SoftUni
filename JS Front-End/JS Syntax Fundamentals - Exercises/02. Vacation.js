function vacantionPrice(countOfgroup, group, day){
    let total = 0;
    switch(group){
        case'Students':
        switch(day){
            case'Friday':
            total = countOfgroup * 8.45;
            if(countOfgroup >= 30){         
                total *=0.85;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Saturday':
             total = countOfgroup * 9.80;
            if(countOfgroup >= 30){         
                total *=0.85;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            } 
            break;
            case'Sunday':
             total = countOfgroup * 10.46;
            if(countOfgroup >= 30){         
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
            total = countOfgroup * 10.9;
            if(countOfgroup >= 100){         
                total -= 109;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Saturday':
             total = countOfgroup * 15.60;
            if(countOfgroup >= 100){         
                total -= 156;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Sunday':
             total = countOfgroup * 16;
            if(countOfgroup >= 100){         
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
            total = countOfgroup * 15;
            if(countOfgroup >= 10 && countOfgroup <= 20){         
                total *= 0.95;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Saturday':
             total = countOfgroup * 20;
            if(countOfgroup >= 10 && countOfgroup <= 20){         
                total *= 0.95;
                console.log('Total price:', total.toFixed(2));
            }
            else{
                console.log('Total price:', total.toFixed(2));
            }
            break;
            case'Sunday':
             total = countOfgroup * 22.5;
            if(countOfgroup >= 10 && countOfgroup <= 20){         
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
