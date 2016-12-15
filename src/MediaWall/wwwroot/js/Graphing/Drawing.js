function DrawMap(source, destination, images) {
    var graph;
    var path;
    var imgsrc;
    var imgwidth;

    //if destination is a particular floor get it's image map, image dimenstions for the wide screen, and the graph for that floor.
    if (destination.substring(0, 3) == "NOA") {
        graph = MapPoints.GetGroundFloor();
        
        imgsrc = images.ground; //scale from 990x1449 -> 1000->1464
        imgwidth = 1464;
    }
    else if (destination.substring(0, 3) == "NOB") {
        graph = MapPoints.GetBasement();
        imgsrc = images.basement; //Scale from 979x1084 -> 1000x1107
        imgwidth = 1107;
    }
    else {
        switch (destination[0]) {
            case "2":
                graph = MapPoints.GetSecondFloor();
                imgsrc = images.two;
                imgwidth = 633; //Scale from 993x620 -> 1000x633  
                break;
            case "3":
                graph = MapPoints.GetThirdFloor();
                imgsrc = images.three;
                imgwidth = 631; //Scale from 988x623 -> 1000x631             
                break;
            case "1":
            default:
                graph = MapPoints.GetFirstFloor();
                imgsrc = images.one; //scale from 990x620 -> 1000->626
                imgwidth = 626;
                break;
        }
    }
    /**/
    path = MapPoints.GetPath(graph, source, destination);
    DrawPath(path, imgsrc, imgwidth, graph.label);

    //DrawNodes(graph, imgsrc, imgwidth);

}



//Graph just has the shortest path in an array.
function DrawPath(nodespath, map, imageheight, label) {
    var iw = 1000; //image width is fixed to 1000px to prevent odd scaling of the text on the picture. 
    canvas = document.getElementById("map");
    var context = canvas.getContext("2d");

    canvas.width = 1000; //Make the canvas the max of all the images. http://www.scriptygoddess.com/resources/proportioncalc.htm
    canvas.height = imageheight + 20;

    var imagemap = new Image();
    imagemap.onload = function () {
        context.drawImage(imagemap, 0, 0, iw, imageheight); //draw our image.

        if (nodespath) {
            var prevx = -1;
            var prevy = -1;
            context.strokeStyle = "#f00"; //draw a red line

            var i = nodespath.length;
            while (i--) { //go thru each node in the path to paint
                var node = nodespath[i];
                context.beginPath(); //first draw our vertex
                //console.log("drawing node", node.name);

                /* Starting and end point label*/
                if (i == nodespath.length - 1 || i == 0) {
                    context.save();
                    context.fillStyle = "#f00";
                    context.font = "24px Arial";
                    context.fillText("X", node.x - 8, node.y + 7);
                    if (i > 0) {
                        context.fillStyle = "#000";
                        context.font = "bold 12px Arial";
                        context.fillText(label, node.x - 20, node.y + 20); //center text under starting node                    
                    }
                    context.restore();
                }
                else {
                    context.arc(node.x, node.y, 4, 0, Math.PI * 2, false); //draw a circle of radius 4
                    context.fill();
                }

                //next draw a line to the previous vertex if it exists.
                context.beginPath();
                context.moveTo(node.x, node.y); //move our pen to the center of our new circle.            
                if (prevx != -1) {
                    context.lineTo(prevx, prevy);
                    context.stroke();
                    //console.log("drawing line from", node, "to", prevx, prevy);
                }
                prevx = node.x;
                prevy = node.y;
            }
        }
    }
    imagemap.src = map;
}


//This method simply draws all the vertexes on the image. used for debugging point position.
function DrawNodes(graph, map, imageheight) {
    var iw = 1000; //image width is fixed to 1000px to prevent odd scaling of the text on the picture. 
    canvas = document.getElementById("map");
    var context = canvas.getContext("2d");

    canvas.width = 1000; //Make the canvas the max of all the images. http://www.scriptygoddess.com/resources/proportioncalc.htm
    canvas.height = imageheight + 20;
    var imagemap = new Image();
    imagemap.onload = function () {
        context.drawImage(imagemap, 0, 0, iw, imageheight); //draw our image.
        var nodes = graph.nodes();
        var i = nodes.length;
        while (i--) {
            var node = nodes[i];

            context.beginPath();
            context.arc(node.value.x, node.value.y, 4, 0, Math.PI * 2, false); //draw a circle of radius 4
            context.fill();
            context.save();
            context.fillStyle = "#f00";
            context.font = '16px san-serif';
            context.fillText(node.value.name, node.value.x - 5, node.value.y + 20);
            context.restore();
        }
    }
    imagemap.src = map;
}