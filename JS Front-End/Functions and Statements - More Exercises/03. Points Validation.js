function pointChecker([x1, y1, x2, y2]){
    const firstPoint = Math.sqrt(Math.pow((0-x1),2) + Math.pow((0-y1),2));
    const isFirstPointValid = (Number.isInteger(firstPoint));
    if(isFirstPointValid){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
    const secondPoint = Math.sqrt(Math.pow((x2-0),2) + Math.pow((y2-0),2));
    const isSecondPointValid = (Number.isInteger(secondPoint));
    if(isSecondPointValid){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }
    else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }
    const distanceBetweenPoints = Math.sqrt(Math.pow((x2-x1),2) + Math.pow((y2-y1),2));
    const isDistanceBetweenPoints = (Number.isInteger(distanceBetweenPoints));
    if(isDistanceBetweenPoints){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }
    else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}
pointChecker([2, 1, 1, 1]);