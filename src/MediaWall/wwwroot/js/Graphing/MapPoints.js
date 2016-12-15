/* File Created: November 13, 2012
   MapPoints.GetFloorX Returns a graph of nodes, edges, and weights for that graph.
   NOTE1 Do not have over lapping points connected. This will cause a cyclic link because weight goes to 0.. I call this the black hole condition.
   Note2 the program always assumes a starting point from the elevator.. However I am creating a grid that will allow for any source and any destination 
*/
var MapPoints = MapPoints || {};

MapPoints.GetFirstFloor = function () {
    var graph = new MGraph.Graph();
    graph.label = "First Floor";   

    var nw1 = 116; //inside nw office, UH side.
    var nw2 = 148; //sub hall
    var nw3 = 174; //lower offfices
    var nw4 = 234; //main hall

    var sw1 = 194; //kitchen hall.
    var sw2 = 185; //sw main hall
    var sw3 = 112; //sw back hall    
    var sw4 = 75;  //inside sw offices.

    var ne1 = 823; //inside deans
    var ne2 = 797; //deans hall
    var ne3 = 761; //deans hall left
    var ne4 = 674; //elevator hall

    var se1 = 551; //inside se offices, closest to the dental school
    var se2 = 518; //south hall
    var se3 = 513; //east hall
    var se4 = 441; //se hall

    var elevator = new MGraph.Point(ne4, 340, "Elevator");
    var a = new MGraph.Point(ne4, nw4, "A"); //north corner
    var b = new MGraph.Point(ne4, se4, "B"); //east corner
    var c = new MGraph.Point(ne4, se2, "C"); //east corner cookies desk
    var cc = new MGraph.Point(702, 497, "1stFloor"); //cookie desk pointer
    var d = new MGraph.Point(606, nw2, "D"); //north west corner
    var e = new MGraph.Point(606, nw4, "E"); //north corner
    var f = new MGraph.Point(303, nw2, "F"); //north corner
    var g = new MGraph.Point(303, nw4, "G"); //north corner
    var h = new MGraph.Point(sw2, nw4, "H"); //SW Corner intersection
    var i = new MGraph.Point(sw2, se4, "I"); //south corner main hall intersection
    var j = new MGraph.Point(sw1, se4, "J"); //south corner main hall intersection

    var mensroom = new MGraph.Point(240, se4, "omensroom"); //south corner main hall intersection
    var womensroom = new MGraph.Point(358, se4, "owomensroom"); //south corner main hall intersection
    var rmensroom = new MGraph.Point(240, se4 - 50, "Mens"); //south corner main hall intersection
    var rwomensroom = new MGraph.Point(358, se4 - 50, "Womens"); //south corner main hall intersection


    var o165c = new MGraph.Point(478, nw4, "o165c"); //outside fd lounge
    var r165c = new MGraph.Point(478, nw4 + 50, "Faculty Staff Lounge"); //inside fs lounge

    var o16601 = new MGraph.Point(555, 491, "o16601"); //outside ffl near info desk
    var o16602 = new MGraph.Point(290, se4, "o16602"); //outside ffl near info desk
    var r16602 = new MGraph.Point(290, 491, "First Floor Lounge Kitchen"); //inside ffl
    var r1660 = new MGraph.Point(500, 491, "First Floor Lounge"); //inside ffl

    //deans area
    var o1040 = new MGraph.Point(742, se2, "o1040");
    var o1060 = new MGraph.Point(ne2, se2, "o1060");
    var o1070 = new MGraph.Point(ne2, 487, "o1070");
    var o1090 = new MGraph.Point(ne2, 462, "o1090");
    var o1100 = new MGraph.Point(ne2, 382, "o1100");
    var o1110 = new MGraph.Point(ne2, 349, "o1110");
    var o1120 = new MGraph.Point(ne2, 295, "o1120");
    var o1130 = new MGraph.Point(ne2, 218, "o1130");
    var o1140 = new MGraph.Point(ne2, 203, "o1140");
    var o1150 = new MGraph.Point(771, 203, "o1150");
    var o1180 = new MGraph.Point(ne2, nw4, "o1180");
    var o1010 = new MGraph.Point(ne2, 331, "o1010");
    var o1020 = new MGraph.Point(ne2, 409, "o1020");
    var o1030 = new MGraph.Point(ne2, 449, "o1030");

    var r1040 = new MGraph.Point(742, se1, "1040");
    var r1060 = new MGraph.Point(ne2, se1, "1060");
    var r1070 = new MGraph.Point(ne1, 487, "1070");
    var r1090 = new MGraph.Point(ne1, 462, "1090");
    var r1100 = new MGraph.Point(ne1, 382, "1100");
    var r1110 = new MGraph.Point(ne1, 349, "1110");
    var r1120 = new MGraph.Point(ne1, 295, "1120");
    var r1130 = new MGraph.Point(ne1, 218, "1130");
    var r1140 = new MGraph.Point(ne2, 153, "1140");
    var r1150 = new MGraph.Point(771, 153, "1150");
    var r1180 = new MGraph.Point(ne3, nw4, "1180");
    var r1010 = new MGraph.Point(ne3, 331, "1010");
    var r1020 = new MGraph.Point(ne3, 409, "1020");
    var r1030 = new MGraph.Point(ne3, 449, "1030");

    //south corner suite.
    //var o1490 = new MGraph.Point(sw3, se4 - 10, "o1490"); 
    var o1500 = new MGraph.Point(sw3, se4, "o1500");
    var o1510 = new MGraph.Point(sw3, 465, "o1510");
    var o1540 = new MGraph.Point(sw3, 516, "o1540");
    var o1550 = new MGraph.Point(sw3, 530, "o1550");
    var o1570 = new MGraph.Point(sw1, 530, "o1570");
    var o1610 = new MGraph.Point(sw1, 529, "o1610");
    var okitchen1 = new MGraph.Point(sw1, 491, "okitchen1");

    var r1490 = new MGraph.Point(sw3, 395, "1490");
    var r1500 = new MGraph.Point(sw4, se4 - 10, "1500"); //this won't draw a straight line but itsk
    var r1510 = new MGraph.Point(sw4, 465, "1510");
    var r1540 = new MGraph.Point(sw4, 516, "1540");
    var r1550 = new MGraph.Point(sw3, se1, "1550");
    var r1570 = new MGraph.Point(sw1, se1, "1570");
    var r1610 = new MGraph.Point(sw1 + 40, 529, "1610");
    var rkitchen1 = new MGraph.Point(sw1 + 40, 491, "kitchen");

    //Northwest corner
    var o1230 = new MGraph.Point(634, nw2, "o1230");
    var o1220 = new MGraph.Point(661, nw2, "o1220");
    var o1240 = new MGraph.Point(573, nw2, "o1240");
    var o1250 = new MGraph.Point(553, nw2, "o1250");
    var o1260 = new MGraph.Point(520, nw2, "o1260");
    var o1270 = new MGraph.Point(470, nw2, "o1270");
    var o1280 = new MGraph.Point(441, nw2, "o1280");
    //var o1290 = new MGraph.Point(435, nw2, "o1290");
    var o1300 = new MGraph.Point(411, nw2, "o1300");
    /*var o1310 = new MGraph.Point(328, nw2, "o1310");*/
    var o1320 = new MGraph.Point(331, nw2, "o1320");
    /*var o1330 = new MGraph.Point(300, nw2, "o1330");*/
    var o1340 = new MGraph.Point(280, nw2, "o1340");
    var o1350 = new MGraph.Point(223, nw2, "o1350");
    var o1360 = new MGraph.Point(196, nw2, "o1360");
    var o1370 = new MGraph.Point(168, nw2, "o1370");
    var o1380 = new MGraph.Point(sw3, nw2, "o1380");
    var o1390 = new MGraph.Point(sw3, nw2 + 13, "o1390");
    var o1420 = new MGraph.Point(sw3, nw2 + 70, "o1420");
    var o1430 = new MGraph.Point(sw3, nw4, "o1430");

    var r1210 = new MGraph.Point(634, nw3, "1210"); //a;ign with 1230
    var r1220 = new MGraph.Point(661, nw1, "1220");
    var r1230 = new MGraph.Point(634, nw1, "1230");
    var r1240 = new MGraph.Point(573, nw3, "1240");
    var r1250 = new MGraph.Point(553, nw1, "1250");
    var r1260 = new MGraph.Point(520, nw1, "1260");
    var r1270 = new MGraph.Point(470, nw3, "1270");
    var r1280 = new MGraph.Point(441, nw3, "1280"); //align with 1290
    var r1290 = new MGraph.Point(441, nw1, "1290");
    var r1300 = new MGraph.Point(411, nw1, "1300");
    var r1310 = new MGraph.Point(331, nw3, "1310"); //align with 1320.
    var r1320 = new MGraph.Point(331, nw1, "1320");
    var r1330 = new MGraph.Point(303, nw1, "1330"); //align with point f
    var r1340 = new MGraph.Point(280, nw3, "1340");
    var r1350 = new MGraph.Point(223, nw1, "1350");
    var r1360 = new MGraph.Point(196, nw1, "1360");
    var r1370 = new MGraph.Point(168, nw3, "1370");
    var r1380 = new MGraph.Point(sw3, nw1, "1380");
    var r1390 = new MGraph.Point(sw4, nw2 + 13, "1390");
    var r1420 = new MGraph.Point(sw4, nw2 + 70, "1420");
    var r1430 = new MGraph.Point(sw4, nw4 + 20, "1430"); //this line will not be straight
    var r1440 = new MGraph.Point(sw3, nw4 + 30, "1430");

    //nw hall 
    graph.addNodeByValue(elevator); //if you add this to an array it'll freeze the browser for whatever reason.    
    graph.addNodesByValue([a, b, c, cc, d, e, f, g, h, i, j, mensroom, womensroom, rmensroom, rwomensroom]);
    graph.addNodesByValue([o165c, r165c, o16601, o16602, r1660, r16602]); //weird points.

    graph.addNodesByValue([o1010, o1020, o1030, o1040, o1060, o1070, o1090, o1100, o1110, o1120, o1130, o1140, o1150, o1180,
                           r1010, r1020, r1030, r1040, r1060, r1070, r1090, r1100, r1110, r1120, r1130, r1140, r1150, r1180]);
    graph.addNodesByValue([o1500, o1510, o1540, o1550, o1570, o1610, okitchen1,
                           r1490, r1500, r1510, r1540, r1550, r1570, r1610, rkitchen1]);
    graph.addNodesByValue([o1230, o1220, o1240, o1250, o1260, o1270, o1280, /*o1290,*/o1300, /*o1310,*/o1320, /*o1330,*/o1340, o1350, o1360, o1370, o1380, o1390, o1420, o1430,
                           r1210, r1220, r1230, r1240, r1250, r1260, r1270, r1280, r1290, r1300, r1310, r1320, r1330, r1340, r1350, r1360, r1370, r1380, r1390, r1420, r1430, r1440]);




    //inner halls
    //ne hall
    graph.addUndirectedEdge(elevator, a, MGraph.CalcCostBetweenPoints(elevator, a));
    graph.addUndirectedEdge(elevator, b, MGraph.CalcCostBetweenPoints(elevator, b));
    graph.addUndirectedEdge(elevator, c, MGraph.CalcCostBetweenPoints(elevator, c));
    graph.addUndirectedEdge(b, c, MGraph.CalcCostBetweenPoints(b, c));
    graph.addUndirectedEdge(elevator, cc, MGraph.CalcCostBetweenPoints(elevator, cc)); //link to cookies desk
    graph.addUndirectedEdge(a, r1180, MGraph.CalcCostBetweenPoints(a, r1180)); //this point might not be necessary
    graph.addUndirectedEdge(a, o1180, MGraph.CalcCostBetweenPoints(a, o1180)); //link ne area to deans office area


    //se hall
    //inner links
    graph.addUndirectedEdge(b, womensroom, MGraph.CalcCostBetweenPoints(b, womensroom));
    graph.addUndirectedEdge(womensroom, o16602, MGraph.CalcCostBetweenPoints(womensroom, o16602));
    graph.addUndirectedEdge(o16602, mensroom, MGraph.CalcCostBetweenPoints(o16602, mensroom));
    graph.addUndirectedEdge(mensroom, j, MGraph.CalcCostBetweenPoints(mensroom, j));
    graph.addUndirectedEdge(j, i, MGraph.CalcCostBetweenPoints(j, i));
    //outer links
    graph.addUndirectedEdge(b, mensroom, MGraph.CalcCostBetweenPoints(b, mensroom));
    graph.addUndirectedEdge(b, o16602, MGraph.CalcCostBetweenPoints(b, o16602));
    graph.addUndirectedEdge(b, j, MGraph.CalcCostBetweenPoints(b, j));
    graph.addUndirectedEdge(b, i, MGraph.CalcCostBetweenPoints(b, i));
    graph.addUndirectedEdge(b, o1500, MGraph.CalcCostBetweenPoints(b, o1500)); //the whole hall.

    graph.addUndirectedEdge(o1500, j, MGraph.CalcCostBetweenPoints(o1500, j));
    graph.addUndirectedEdge(o1500, mensroom, MGraph.CalcCostBetweenPoints(o1500, mensroom));
    graph.addUndirectedEdge(o1500, o16602, MGraph.CalcCostBetweenPoints(o1500, o16602));
    graph.addUndirectedEdge(o1500, womensroom, MGraph.CalcCostBetweenPoints(o1500, womensroom));

    graph.addUndirectedEdge(i, mensroom, MGraph.CalcCostBetweenPoints(i, mensroom));
    graph.addUndirectedEdge(i, o16602, MGraph.CalcCostBetweenPoints(i, o16602));
    graph.addUndirectedEdge(i, womensroom, MGraph.CalcCostBetweenPoints(i, womensroom));

    graph.addUndirectedEdge(j, mensroom, MGraph.CalcCostBetweenPoints(j, mensroom));
    graph.addUndirectedEdge(j, o16602, MGraph.CalcCostBetweenPoints(j, o16602));
    graph.addUndirectedEdge(j, womensroom, MGraph.CalcCostBetweenPoints(j, womensroom));

    graph.addUndirectedEdge(mensroom, rmensroom, MGraph.CalcCostBetweenPoints(mensroom, rmensroom));
    graph.addUndirectedEdge(womensroom, rwomensroom, MGraph.CalcCostBetweenPoints(womensroom, rwomensroom));
    //sw hall
    graph.addUndirectedEdge(h, i, MGraph.CalcCostBetweenPoints(h, i));
    //nw hall   
    graph.addUndirectedEdge(a, e, MGraph.CalcCostBetweenPoints(a, e));
    graph.addUndirectedEdge(a, o165c, MGraph.CalcCostBetweenPoints(a, o165c));
    graph.addUndirectedEdge(o165c, r165c, MGraph.CalcCostBetweenPoints(o165c, r165c));
    graph.addUndirectedEdge(a, g, MGraph.CalcCostBetweenPoints(a, g));
    graph.addUndirectedEdge(a, h, MGraph.CalcCostBetweenPoints(a, h));
    graph.addUndirectedEdge(a, o1430, MGraph.CalcCostBetweenPoints(a, o1430)); //Link the length of the hall

    graph.addUndirectedEdge(e, d, MGraph.CalcCostBetweenPoints(e, d)); //short ns
    graph.addUndirectedEdge(g, f, MGraph.CalcCostBetweenPoints(g, f)); //short ns

    graph.addUndirectedEdge(h, e, MGraph.CalcCostBetweenPoints(h, e));
    graph.addUndirectedEdge(h, o165c, MGraph.CalcCostBetweenPoints(h, o165c));
    graph.addUndirectedEdge(h, o1430, MGraph.CalcCostBetweenPoints(h, o1430));

    //deans hall - 1040-1180
    //inner links
    graph.addUndirectedEdge(c, o1040, MGraph.CalcCostBetweenPoints(c, o1040));
    graph.addUndirectedEdge(o1040, o1060, MGraph.CalcCostBetweenPoints(o1040, o1060));
    graph.addUndirectedEdge(c, o1060, MGraph.CalcCostBetweenPoints(c, o1060)); //outer link 
    graph.addUndirectedEdge(o1060, o1070, MGraph.CalcCostBetweenPoints(o1060, o1070));
    graph.addUndirectedEdge(o1070, o1090, MGraph.CalcCostBetweenPoints(o1070, o1090));
    graph.addUndirectedEdge(o1090, o1030, MGraph.CalcCostBetweenPoints(o1090, o1030));
    graph.addUndirectedEdge(o1030, o1020, MGraph.CalcCostBetweenPoints(o1030, o1020));
    graph.addUndirectedEdge(o1020, o1100, MGraph.CalcCostBetweenPoints(o1020, o1100));
    graph.addUndirectedEdge(o1100, o1110, MGraph.CalcCostBetweenPoints(o1100, o1110));
    graph.addUndirectedEdge(o1110, o1010, MGraph.CalcCostBetweenPoints(o1110, o1010));
    graph.addUndirectedEdge(o1010, o1120, MGraph.CalcCostBetweenPoints(o1010, o1120));
    graph.addUndirectedEdge(o1120, o1180, MGraph.CalcCostBetweenPoints(o1120, o1180));
    graph.addUndirectedEdge(o1180, o1130, MGraph.CalcCostBetweenPoints(o1180, o1130));
    graph.addUndirectedEdge(o1130, o1140, MGraph.CalcCostBetweenPoints(o1130, o1140));
    graph.addUndirectedEdge(o1140, o1150, MGraph.CalcCostBetweenPoints(o1140, o1150));
    //outer links.
    graph.addUndirectedEdge(o1060, o1030, MGraph.CalcCostBetweenPoints(o1060, o1030));
    graph.addUndirectedEdge(o1060, o1090, MGraph.CalcCostBetweenPoints(o1060, o1090));
    graph.addUndirectedEdge(o1060, o1020, MGraph.CalcCostBetweenPoints(o1060, o1020));
    graph.addUndirectedEdge(o1060, o1100, MGraph.CalcCostBetweenPoints(o1060, o1100));
    graph.addUndirectedEdge(o1060, o1110, MGraph.CalcCostBetweenPoints(o1060, o1110));
    graph.addUndirectedEdge(o1060, o1010, MGraph.CalcCostBetweenPoints(o1060, o1010));
    graph.addUndirectedEdge(o1060, o1120, MGraph.CalcCostBetweenPoints(o1060, o1120));
    graph.addUndirectedEdge(o1060, o1180, MGraph.CalcCostBetweenPoints(o1060, o1180));
    graph.addUndirectedEdge(o1060, o1130, MGraph.CalcCostBetweenPoints(o1060, o1130));
    graph.addUndirectedEdge(o1060, o1140, MGraph.CalcCostBetweenPoints(o1060, o1140));

    graph.addUndirectedEdge(o1140, o1070, MGraph.CalcCostBetweenPoints(o1140, o1070));
    graph.addUndirectedEdge(o1140, o1030, MGraph.CalcCostBetweenPoints(o1140, o1030));
    graph.addUndirectedEdge(o1140, o1090, MGraph.CalcCostBetweenPoints(o1140, o1090));
    graph.addUndirectedEdge(o1140, o1020, MGraph.CalcCostBetweenPoints(o1140, o1020));
    graph.addUndirectedEdge(o1140, o1100, MGraph.CalcCostBetweenPoints(o1140, o1100));
    graph.addUndirectedEdge(o1140, o1110, MGraph.CalcCostBetweenPoints(o1140, o1110));
    graph.addUndirectedEdge(o1140, o1010, MGraph.CalcCostBetweenPoints(o1140, o1010));
    graph.addUndirectedEdge(o1140, o1120, MGraph.CalcCostBetweenPoints(o1140, o1120));
    graph.addUndirectedEdge(o1140, o1180, MGraph.CalcCostBetweenPoints(o1140, o1180));
    graph.addUndirectedEdge(o1140, o1130, MGraph.CalcCostBetweenPoints(o1140, o1130));

    graph.addUndirectedEdge(o1180, o1070, MGraph.CalcCostBetweenPoints(o1180, o1070));
    graph.addUndirectedEdge(o1180, o1030, MGraph.CalcCostBetweenPoints(o1180, o1030));
    graph.addUndirectedEdge(o1180, o1090, MGraph.CalcCostBetweenPoints(o1180, o1090));
    graph.addUndirectedEdge(o1180, o1020, MGraph.CalcCostBetweenPoints(o1180, o1020));
    graph.addUndirectedEdge(o1180, o1100, MGraph.CalcCostBetweenPoints(o1180, o1100));
    graph.addUndirectedEdge(o1180, o1110, MGraph.CalcCostBetweenPoints(o1180, o1110));
    graph.addUndirectedEdge(o1180, o1010, MGraph.CalcCostBetweenPoints(o1180, o1010));

    graph.addUndirectedEdge(o1180, o1060, MGraph.CalcCostBetweenPoints(o1180, o1060)); //the whole hall 
    graph.addUndirectedEdge(o1140, o1060, MGraph.CalcCostBetweenPoints(o1140, o1060)); //the whole hall.
    //in room links.
    graph.addUndirectedEdge(o1180, r1180, MGraph.CalcCostBetweenPoints(o1180, r1180));
    graph.addUndirectedEdge(o1150, r1150, MGraph.CalcCostBetweenPoints(o1150, r1150));
    graph.addUndirectedEdge(o1140, r1140, MGraph.CalcCostBetweenPoints(o1140, r1140));
    graph.addUndirectedEdge(o1130, r1130, MGraph.CalcCostBetweenPoints(o1130, r1130));
    graph.addUndirectedEdge(o1120, r1120, MGraph.CalcCostBetweenPoints(o1120, r1120));
    graph.addUndirectedEdge(o1110, r1110, MGraph.CalcCostBetweenPoints(o1110, r1110));
    graph.addUndirectedEdge(o1100, r1100, MGraph.CalcCostBetweenPoints(o1100, r1100));
    graph.addUndirectedEdge(o1090, r1090, MGraph.CalcCostBetweenPoints(o1090, r1090));
    graph.addUndirectedEdge(o1070, r1070, MGraph.CalcCostBetweenPoints(o1070, r1070));
    graph.addUndirectedEdge(o1060, r1060, MGraph.CalcCostBetweenPoints(o1060, r1060));
    graph.addUndirectedEdge(o1040, r1040, MGraph.CalcCostBetweenPoints(o1040, r1040));
    graph.addUndirectedEdge(o1030, r1030, MGraph.CalcCostBetweenPoints(o1030, r1030));
    graph.addUndirectedEdge(o1020, r1020, MGraph.CalcCostBetweenPoints(o1020, r1020));
    graph.addUndirectedEdge(o1010, r1010, MGraph.CalcCostBetweenPoints(o1010, r1010));

    //South Corner 1500 suite.
    //inner links
    graph.addUndirectedEdge(i, o1500, MGraph.CalcCostBetweenPoints(i, o1500));
    //graph.addUndirectedEdge(o1500, o1490, MGraph.CalcCostBetweenPoints(o1500, o1490));
    graph.addUndirectedEdge(o1500, o1510, MGraph.CalcCostBetweenPoints(o1500, o1510));
    graph.addUndirectedEdge(o1510, o1540, MGraph.CalcCostBetweenPoints(o1510, o1540));
    graph.addUndirectedEdge(o1540, o1550, MGraph.CalcCostBetweenPoints(o1540, o1550));
    graph.addUndirectedEdge(o1550, o1570, MGraph.CalcCostBetweenPoints(o1550, o1570));
    graph.addUndirectedEdge(o1570, o1610, MGraph.CalcCostBetweenPoints(o1570, o1610)); //1px apart
    graph.addUndirectedEdge(o1610, okitchen1, MGraph.CalcCostBetweenPoints(o1610, okitchen1));
    graph.addUndirectedEdge(okitchen1, j, MGraph.CalcCostBetweenPoints(okitchen1, j));
    //outerlinks
    graph.addUndirectedEdge(o1500, o1540, MGraph.CalcCostBetweenPoints(o1500, o1540));
    graph.addUndirectedEdge(o1500, o1550, MGraph.CalcCostBetweenPoints(o1500, o1550));
    graph.addUndirectedEdge(j, o1610, MGraph.CalcCostBetweenPoints(j, o1610));
    graph.addUndirectedEdge(j, o1570, MGraph.CalcCostBetweenPoints(j, o1570));
    //in room links
    graph.addUndirectedEdge(o1500, r1490, MGraph.CalcCostBetweenPoints(o1500, r1490));
    graph.addUndirectedEdge(o1500, r1500, MGraph.CalcCostBetweenPoints(o1500, r1500));
    graph.addUndirectedEdge(o1510, r1510, MGraph.CalcCostBetweenPoints(o1510, r1510));
    graph.addUndirectedEdge(o1540, r1540, MGraph.CalcCostBetweenPoints(o1540, r1540));
    graph.addUndirectedEdge(o1550, r1550, MGraph.CalcCostBetweenPoints(o1550, r1550));
    graph.addUndirectedEdge(o1570, r1570, MGraph.CalcCostBetweenPoints(o1570, r1570));
    graph.addUndirectedEdge(o1610, r1610, MGraph.CalcCostBetweenPoints(o1610, r1610));
    graph.addUndirectedEdge(okitchen1, rkitchen1, MGraph.CalcCostBetweenPoints(okitchen1, rkitchen1));

    //NW Offices
    //inner links
    graph.addUndirectedEdge(d, o1230, MGraph.CalcCostBetweenPoints(d, o1230));
    graph.addUndirectedEdge(o1220, o1230, MGraph.CalcCostBetweenPoints(o1220, o1230));
    graph.addUndirectedEdge(d, o1240, MGraph.CalcCostBetweenPoints(d, o1240));
    graph.addUndirectedEdge(o1240, o1250, MGraph.CalcCostBetweenPoints(o1240, o1250));
    graph.addUndirectedEdge(o1250, o1260, MGraph.CalcCostBetweenPoints(o1250, o1260));
    graph.addUndirectedEdge(o1260, o1270, MGraph.CalcCostBetweenPoints(o1260, o1270));
    graph.addUndirectedEdge(o1270, o1280, MGraph.CalcCostBetweenPoints(o1270, o1280));
    graph.addUndirectedEdge(o1280, o1300, MGraph.CalcCostBetweenPoints(o1270, o1300));
    graph.addUndirectedEdge(o1300, o1320, MGraph.CalcCostBetweenPoints(o1300, o1320));
    graph.addUndirectedEdge(o1320, f, MGraph.CalcCostBetweenPoints(o1320, f));
    graph.addUndirectedEdge(f, o1340, MGraph.CalcCostBetweenPoints(o1320, o1340));
    graph.addUndirectedEdge(o1340, o1350, MGraph.CalcCostBetweenPoints(o1340, o1350));
    graph.addUndirectedEdge(o1350, o1360, MGraph.CalcCostBetweenPoints(o1350, o1360));
    graph.addUndirectedEdge(o1360, o1370, MGraph.CalcCostBetweenPoints(o1360, o1370));
    graph.addUndirectedEdge(o1370, o1380, MGraph.CalcCostBetweenPoints(o1370, o1380));
    graph.addUndirectedEdge(o1380, o1390, MGraph.CalcCostBetweenPoints(o1380, o1390));
    graph.addUndirectedEdge(o1390, o1420, MGraph.CalcCostBetweenPoints(o1380, o1420));
    graph.addUndirectedEdge(o1420, o1430, MGraph.CalcCostBetweenPoints(o1420, o1430));

    //outer links
    graph.addUndirectedEdge(d, o1220, MGraph.CalcCostBetweenPoints(d, o1220)); //outlink here 
    graph.addUndirectedEdge(d, o1250, MGraph.CalcCostBetweenPoints(d, o1250));
    graph.addUndirectedEdge(d, o1260, MGraph.CalcCostBetweenPoints(d, o1260));
    graph.addUndirectedEdge(d, o1270, MGraph.CalcCostBetweenPoints(d, o1270));
    graph.addUndirectedEdge(d, o1280, MGraph.CalcCostBetweenPoints(d, o1280));
    graph.addUndirectedEdge(d, o1300, MGraph.CalcCostBetweenPoints(d, o1300));
    graph.addUndirectedEdge(d, o1320, MGraph.CalcCostBetweenPoints(d, o1320));

    graph.addUndirectedEdge(d, f, MGraph.CalcCostBetweenPoints(d, f));
    graph.addUndirectedEdge(d, o1340, MGraph.CalcCostBetweenPoints(d, o1340));
    graph.addUndirectedEdge(d, o1350, MGraph.CalcCostBetweenPoints(d, o1350));
    graph.addUndirectedEdge(d, o1360, MGraph.CalcCostBetweenPoints(d, o1360));
    graph.addUndirectedEdge(d, o1370, MGraph.CalcCostBetweenPoints(d, o1370));
    graph.addUndirectedEdge(d, o1380, MGraph.CalcCostBetweenPoints(d, o1380));
    //reverse hall
    graph.addUndirectedEdge(o1380, o1220, MGraph.CalcCostBetweenPoints(o1380, o1220)); //outlink here 
    graph.addUndirectedEdge(o1380, o1230, MGraph.CalcCostBetweenPoints(o1380, o1230)); //outlink here 
    graph.addUndirectedEdge(o1380, o1240, MGraph.CalcCostBetweenPoints(o1380, o1240)); //outlink here 
    graph.addUndirectedEdge(o1380, o1250, MGraph.CalcCostBetweenPoints(o1380, o1250));
    graph.addUndirectedEdge(o1380, o1260, MGraph.CalcCostBetweenPoints(o1380, o1260));
    graph.addUndirectedEdge(o1380, o1270, MGraph.CalcCostBetweenPoints(o1380, o1270));
    graph.addUndirectedEdge(o1380, o1280, MGraph.CalcCostBetweenPoints(o1380, o1280));
    graph.addUndirectedEdge(o1380, o1300, MGraph.CalcCostBetweenPoints(o1380, o1300));
    graph.addUndirectedEdge(o1380, o1320, MGraph.CalcCostBetweenPoints(o1380, o1320));
    graph.addUndirectedEdge(o1380, f, MGraph.CalcCostBetweenPoints(o1380, f));
    graph.addUndirectedEdge(o1380, o1340, MGraph.CalcCostBetweenPoints(o1380, o1340));
    graph.addUndirectedEdge(o1380, o1350, MGraph.CalcCostBetweenPoints(o1380, o1350));
    graph.addUndirectedEdge(o1380, o1360, MGraph.CalcCostBetweenPoints(o1380, o1360));
    //south hall
    graph.addUndirectedEdge(o1380, o1420, MGraph.CalcCostBetweenPoints(o1380, o1420));
    graph.addUndirectedEdge(o1380, o1430, MGraph.CalcCostBetweenPoints(o1380, o1430));
    graph.addUndirectedEdge(o1390, o1430, MGraph.CalcCostBetweenPoints(o1390, o1430));

    //in office links.
    graph.addUndirectedEdge(o1230, r1230, MGraph.CalcCostBetweenPoints(o1230, r1230));
    graph.addUndirectedEdge(o1230, r1210, MGraph.CalcCostBetweenPoints(o1230, r1210));
    graph.addUndirectedEdge(o1220, r1220, MGraph.CalcCostBetweenPoints(o1220, r1220));
    graph.addUndirectedEdge(o1240, r1240, MGraph.CalcCostBetweenPoints(o1240, r1240));
    graph.addUndirectedEdge(o1250, r1250, MGraph.CalcCostBetweenPoints(o1250, r1250));
    graph.addUndirectedEdge(o1260, r1260, MGraph.CalcCostBetweenPoints(o1260, r1260));
    graph.addUndirectedEdge(o1270, r1270, MGraph.CalcCostBetweenPoints(o1270, r1270));
    graph.addUndirectedEdge(o1280, r1280, MGraph.CalcCostBetweenPoints(o1280, r1280));
    graph.addUndirectedEdge(o1280, r1290, MGraph.CalcCostBetweenPoints(o1280, r1290));
    graph.addUndirectedEdge(o1300, r1300, MGraph.CalcCostBetweenPoints(o1300, r1300));
    graph.addUndirectedEdge(o1320, r1310, MGraph.CalcCostBetweenPoints(o1320, r1310));
    graph.addUndirectedEdge(o1320, r1320, MGraph.CalcCostBetweenPoints(o1320, r1320));
    graph.addUndirectedEdge(f, r1330, MGraph.CalcCostBetweenPoints(f, r1330));
    graph.addUndirectedEdge(o1340, r1340, MGraph.CalcCostBetweenPoints(o1340, r1340));
    graph.addUndirectedEdge(o1350, r1350, MGraph.CalcCostBetweenPoints(o1350, r1350));
    graph.addUndirectedEdge(o1360, r1360, MGraph.CalcCostBetweenPoints(o1360, r1360));
    graph.addUndirectedEdge(o1370, r1370, MGraph.CalcCostBetweenPoints(o1370, r1370));
    graph.addUndirectedEdge(o1380, r1380, MGraph.CalcCostBetweenPoints(o1380, r1380));
    graph.addUndirectedEdge(o1390, r1390, MGraph.CalcCostBetweenPoints(o1390, r1390));
    graph.addUndirectedEdge(o1420, r1420, MGraph.CalcCostBetweenPoints(o1420, r1420));
    graph.addUndirectedEdge(o1430, r1430, MGraph.CalcCostBetweenPoints(o1430, r1430));
    graph.addUndirectedEdge(o1430, r1440, MGraph.CalcCostBetweenPoints(o1430, r1440));

    //FFL lounge map
    graph.addUndirectedEdge(b, o16601, MGraph.CalcCostBetweenPoints(b, o16601));
    graph.addUndirectedEdge(c, o16601, MGraph.CalcCostBetweenPoints(b, o16601));
    graph.addUndirectedEdge(o16601, r1660, MGraph.CalcCostBetweenPoints(o16601, r1660));
    graph.addUndirectedEdge(o16602, r16602, MGraph.CalcCostBetweenPoints(o16602, r16602));
    graph.addUndirectedEdge(r16602, r1660, MGraph.CalcCostBetweenPoints(r16602, r1660));
    graph.addUndirectedEdge(r16602, rkitchen1, 10000); //make the cost really high here to prevent people getting maps thru the ffl thru the kitchen to get to 1500 suite

    return graph;
}

MapPoints.GetSecondFloor = function () {
    var graph = new MGraph.Graph();
    graph.label = "Second Floor";

    var sehall = 447; //southeast hall
    var nwhall = 240; //northwest hall
    var swhall = 188; //southwest hall
    var nehall = 674; //elevator line

    var ne1 = 796; //cfrs line 2
    var ne2 = 766; //cfrs line 1

    var ne4 = 605; //206a hallline
    var ne5 = 552; //230 se line
    var ne6 = 126; //219 suite line
    var nw1 = 149; //206 suite
    var se1 = 538; //203suite


    var elevator = new MGraph.Point(nehall, 340, "Elevator");
    var ocfrs = new MGraph.Point(ne2, 340, "Outside CFRS");
    var a = new MGraph.Point(nehall, 240, "A"); //north corner
    var b = new MGraph.Point(nehall, sehall, "B"); //east corner
    var c = new MGraph.Point(ne4, nw1, "206A"); //206 suite hallway
    var d = new MGraph.Point(ne4, 240, "D"); //midpoint in nw hall
    var e = new MGraph.Point(550, sehall, "E"); //midpoint in se hall
    var f = new MGraph.Point(383, 130, "F"); //corner of 215c and 213a
    var g = new MGraph.Point(swhall, 330, "G"); //corner of 215c and 213a
    var h = new MGraph.Point(swhall, sehall, "H"); //corner of 221A

    var mensroom = new MGraph.Point(235, sehall - 40, "Men"); //corner of 215c and 213a
    var womensroom = new MGraph.Point(355, sehall - 40, "Women"); //corner of 215c and 213a    
    var owomensroom = new MGraph.Point(355, sehall, "oWomen"); //corner of 215c and 213a

    //204
    var o204c = new MGraph.Point(ne1, 270, "o204C");
    var o204d = new MGraph.Point(ne1, 191, "o204D");
    var o204e = new MGraph.Point(ne1, 157, "o204E");
    var o204f = new MGraph.Point(ne2, nw1, "o204F");
    var o204g = new MGraph.Point(718, nw1, "o204G");
    var o204h = new MGraph.Point(ne2, 191, "o204H");
    var o204j = new MGraph.Point(ne2, 270, "o204J");

    var r204c = new MGraph.Point(ne1 + 40, 270, "204C");
    var r204d = new MGraph.Point(ne1 + 40, 191, "204D");
    var r204e = new MGraph.Point(ne1 + 40, 157, "204E");
    var r204f = new MGraph.Point(ne2, nw1 - 40, "204F");
    var r204g = new MGraph.Point(718, nw1 - 40, "204G");
    var r204h = new MGraph.Point(ne2 - 40, 191, "204H");
    var r204j = new MGraph.Point(ne2 - 40, 270, "204J");

    //203
    var o203b = new MGraph.Point(ne2, 410, "o203B");
    var o203c = new MGraph.Point(ne2, 490, "o203C");
    var o203d = new MGraph.Point(718, se1, "o203D");
    var o203e = new MGraph.Point(ne2, se1, "o203E");
    var o203f = new MGraph.Point(ne1, 524, "o203F");
    var o203g = new MGraph.Point(ne1, 490, "o203G");
    var o203h = new MGraph.Point(ne1, 410, "o203H");

    var r203b = new MGraph.Point(ne2 - 40, 410, "203B");
    var r203c = new MGraph.Point(ne2 - 40, 490, "203C");
    var r203d = new MGraph.Point(718, se1 + 40, "203D");
    var r203e = new MGraph.Point(ne2, se1 + 40, "203E");
    var r203f = new MGraph.Point(ne1 + 40, 524, "203F");
    var r203g = new MGraph.Point(ne1 + 40, 490, "203G");
    var r203h = new MGraph.Point(ne1 + 40, 410, "203H");
    var r203j = new MGraph.Point(ne1, 340, "203J");
    //230
    var o230b = new MGraph.Point(ne5, 506, "o230B");
    var o230c = new MGraph.Point(ne5, se1, "o230C/D");
    var o230e = new MGraph.Point(599, se1, "o230E");
    var o230f = new MGraph.Point(634, se1, "o230F");
    var o230g = new MGraph.Point(626, se1, "o230G");
    var o230h = new MGraph.Point(684, se1, "o230H");

    var r230b = new MGraph.Point(ne5 - 40, 506, "230B");
    var r230c = new MGraph.Point(ne5 - 40, se1, "230C");
    var r230d = new MGraph.Point(ne5, se1 + 40, "230D");
    var r230e = new MGraph.Point(599, se1 - 40, "230E");
    var r230f = new MGraph.Point(634, se1 - 40, "230F");
    var r230g = new MGraph.Point(626, se1 + 40, "230G");
    var r230h = new MGraph.Point(684, se1 + 40, "230H");
    var r230j = new MGraph.Point(684, se1 - 40, "230J");

    //206
    var o206b = new MGraph.Point(630, nw1, "o206B");
    var o206c = new MGraph.Point(684, nw1, "o206C");

    var r206b = new MGraph.Point(630, nw1 + 40, "206B");
    var r206c = new MGraph.Point(684, nw1 + 40, "206C");
    var r206d = new MGraph.Point(684, nw1 - 40, "206D");
    var r206e = new MGraph.Point(630, nw1 - 40, "206E");

    //nwhall
    var o2070 = new MGraph.Point(551, nwhall, "o2070");
    var o2080 = new MGraph.Point(522, nwhall, "o2080");
    var o2090 = new MGraph.Point(426, nwhall, "o2090");
    var o213a = new MGraph.Point(383, nwhall, "o213A");
    var o2140 = new MGraph.Point(230, nwhall, "o2140");
    var o215a = new MGraph.Point(swhall, nwhall, "o215A");

    var r2070 = new MGraph.Point(551, nwhall - 40, "2070");
    var r2080 = new MGraph.Point(522, nwhall - 40, "2080");
    var r2090 = new MGraph.Point(426, nwhall - 40, "2090");
    var r213a = new MGraph.Point(383, nwhall - 40, "213A");
    var r2140 = new MGraph.Point(230, nwhall - 40, "2140");
    var r215a = new MGraph.Point(swhall, nwhall - 40, "215A");

    //sehall

    var o2230 = new MGraph.Point(284, sehall, "o2230");
    var o221a = new MGraph.Point(230, sehall, "o221A");
    var o221b = new MGraph.Point(230, 575, "o221B");
    var o227b = new MGraph.Point(464, sehall, "o227b");
    //var o227b = new MGraph.Point(464, 406, "o227B");
    var o2260 = new MGraph.Point(436, sehall, "o2260");
    var o2250 = new MGraph.Point(390, sehall, "o2250");

    var r2280 = new MGraph.Point(464, sehall + 40, "2280");
    var r2230 = new MGraph.Point(284, sehall + 40, "2230");
    var r221a = new MGraph.Point(230, sehall + 40, "221A");
    var r221b = new MGraph.Point(180, 575, "221B");
    var r227b = new MGraph.Point(464, sehall - 40, "227B");
    var r2260 = new MGraph.Point(436, sehall - 40, "2260");
    var r2250 = new MGraph.Point(390, sehall - 40, "2250");

    //219 suite

    var o219c = new MGraph.Point(ne6, 190, "o219C");
    var o219d = new MGraph.Point(ne6, 220, "o219D");
    var o219e = new MGraph.Point(ne6, 270, "o219E");
    var o219f = new MGraph.Point(ne6, 330, "o219F"); //219 entrance hall
    var o219h = new MGraph.Point(ne6, 410, "o219H");

    var r219a = new MGraph.Point(ne6, 291, "219A");
    var r219b = new MGraph.Point(ne6, 165, "219B");
    var r219c = new MGraph.Point(ne6 - 40, 190, "219C");
    var r219d = new MGraph.Point(ne6 - 40, 220, "219D");
    var r219e = new MGraph.Point(ne6 - 40, 270, "219E");
    var r219f = new MGraph.Point(ne6 - 40, 330, "219F"); //219 entrance hall
    var r219g = new MGraph.Point(ne6, 360, "219G");
    var r219h = new MGraph.Point(ne6 - 40, 410, "219H");
    var r219i = new MGraph.Point(ne6, 465, "219I");

    //PHD Lounge
    var r215b = new MGraph.Point(335, 130, "215B"); //PHD Lounge
    var r215d = new MGraph.Point(295, 130, "215D"); //isolation room


    //graph.addNodesByValue([elevator]);
    graph.addNodeByValue(elevator); //if you add this to an array it'll freeze the browser for whatever reason.    
    graph.addNodesByValue([ocfrs, a, b, c, d, e, f, g, h, mensroom, womensroom, owomensroom,
    o204c, o204d, o204e, o204f, o204g, o204h, o204j, r204c, r204d, r204e, r204f, r204g, r204h, r204j, //204 suite 
    o203b, o203c, o203d, o203e, o203f, o203g, o203h, r203b, r203c, r203d, r203e, r203f, r203g, r203h, r203j, //203suite   
    o230b, o230c, o230e, o230f, o230g, o230h, r230b, r230c, r230d, r230e, r230f, r230g, r230h, r230j,  //230suite
    o206b, o206c, r206b, r206c, r206d, r206e, //206suite
    o2070, o2080, o2090, o213a, o2140, o215a, r2070, r2080, r2090, r213a, r215b, r215d, r2140, r215a, //NW Hall
    o2230, o221a, o221b, o2250, o2260, o227b, r2280, r2230, r221a, r221b, r2250, r2260, r227b,  //SE Hall
    o219c, o219d, o219e, o219f, o219h, r219a, r219b, r219c, r219d, r219e, r219f, r219g, r219h, r219i]); //219 suite

    //ne hall
    graph.addUndirectedEdge(elevator, ocfrs, MGraph.CalcCostBetweenPoints(elevator, ocfrs));
    graph.addUndirectedEdge(elevator, a, MGraph.CalcCostBetweenPoints(elevator, a));
    graph.addUndirectedEdge(elevator, b, MGraph.CalcCostBetweenPoints(elevator, b));

    //se hall
    //inner loops
    graph.addUndirectedEdge(b, e, MGraph.CalcCostBetweenPoints(b, e));
    graph.addUndirectedEdge(e, o227b, MGraph.CalcCostBetweenPoints(e, o227b));
    graph.addUndirectedEdge(o227b, o2260, MGraph.CalcCostBetweenPoints(o227b, o2260));
    graph.addUndirectedEdge(o2260, o2250, MGraph.CalcCostBetweenPoints(o2260, o2250));
    graph.addUndirectedEdge(o2250, owomensroom, MGraph.CalcCostBetweenPoints(o2250, owomensroom));
    graph.addUndirectedEdge(owomensroom, o2230, MGraph.CalcCostBetweenPoints(owomensroom, o2230));
    graph.addUndirectedEdge(o2230, o221a, MGraph.CalcCostBetweenPoints(o2230, o221a));
    graph.addUndirectedEdge(o221a, h, MGraph.CalcCostBetweenPoints(o221a, h));
    graph.addUndirectedEdge(b, h, MGraph.CalcCostBetweenPoints(b, h));
    graph.addUndirectedEdge(e, h, MGraph.CalcCostBetweenPoints(e, h));

    //outer loops
    graph.addUndirectedEdge(b, o227b, MGraph.CalcCostBetweenPoints(b, o227b));
    graph.addUndirectedEdge(b, o2260, MGraph.CalcCostBetweenPoints(b, o2260));
    graph.addUndirectedEdge(b, o2250, MGraph.CalcCostBetweenPoints(b, o2250));
    graph.addUndirectedEdge(b, owomensroom, MGraph.CalcCostBetweenPoints(b, owomensroom));
    graph.addUndirectedEdge(b, o2230, MGraph.CalcCostBetweenPoints(b, o2230));
    graph.addUndirectedEdge(b, o221a, MGraph.CalcCostBetweenPoints(b, o221a));

    graph.addUndirectedEdge(h, o2230, MGraph.CalcCostBetweenPoints(h, o2230));
    graph.addUndirectedEdge(h, owomensroom, MGraph.CalcCostBetweenPoints(h, owomensroom));
    graph.addUndirectedEdge(h, o2250, MGraph.CalcCostBetweenPoints(h, o2250));
    graph.addUndirectedEdge(h, o2260, MGraph.CalcCostBetweenPoints(h, o2260));
    graph.addUndirectedEdge(h, o227b, MGraph.CalcCostBetweenPoints(h, o227b));
    //in room

    graph.addUndirectedEdge(o227b, r227b, MGraph.CalcCostBetweenPoints(o227b, r227b));
    graph.addUndirectedEdge(o227b, r2280, MGraph.CalcCostBetweenPoints(o227b, r2280));
    graph.addUndirectedEdge(o2260, r2260, MGraph.CalcCostBetweenPoints(o2260, r2260));
    graph.addUndirectedEdge(o2260, r2250, MGraph.CalcCostBetweenPoints(o2260, r2250));
    graph.addUndirectedEdge(owomensroom, womensroom, MGraph.CalcCostBetweenPoints(owomensroom, womensroom));
    graph.addUndirectedEdge(o2230, r2230, MGraph.CalcCostBetweenPoints(o2230, r2230));

    graph.addUndirectedEdge(o221a, r221a, MGraph.CalcCostBetweenPoints(o221a, r221a));
    graph.addUndirectedEdge(o221a, o221b, MGraph.CalcCostBetweenPoints(o221a, r221b));
    graph.addUndirectedEdge(o221b, r221b, MGraph.CalcCostBetweenPoints(o221b, r221b));

    //204 suite
    //inner links
    graph.addUndirectedEdge(ocfrs, o204j, MGraph.CalcCostBetweenPoints(ocfrs, o204j));
    graph.addUndirectedEdge(ocfrs, o204h, MGraph.CalcCostBetweenPoints(ocfrs, o204h));
    graph.addUndirectedEdge(ocfrs, o204f, MGraph.CalcCostBetweenPoints(ocfrs, o204f));
    //from 204j   
    graph.addUndirectedEdge(o204j, o204h, MGraph.CalcCostBetweenPoints(o204j, o204h));
    graph.addUndirectedEdge(o204j, o204c, MGraph.CalcCostBetweenPoints(o204j, o204c));
    graph.addUndirectedEdge(o204j, o204d, MGraph.CalcCostBetweenPoints(o204j, o204d));
    graph.addUndirectedEdge(o204j, o204e, MGraph.CalcCostBetweenPoints(o204j, o204e));
    //from 204h
    graph.addUndirectedEdge(o204h, o204e, MGraph.CalcCostBetweenPoints(o204h, o204e));
    graph.addUndirectedEdge(o204h, o204d, MGraph.CalcCostBetweenPoints(o204h, o204d));
    graph.addUndirectedEdge(o204h, o204c, MGraph.CalcCostBetweenPoints(o204h, o204c));
    //from 204f    
    graph.addUndirectedEdge(o204f, o204g, MGraph.CalcCostBetweenPoints(o204f, o204g));
    graph.addUndirectedEdge(o204f, o204j, MGraph.CalcCostBetweenPoints(o204f, o204h));
    graph.addUndirectedEdge(o204f, o204c, MGraph.CalcCostBetweenPoints(o204f, o204c));
    graph.addUndirectedEdge(o204f, o204d, MGraph.CalcCostBetweenPoints(o204f, o204d));
    graph.addUndirectedEdge(o204f, o204e, MGraph.CalcCostBetweenPoints(o204f, o204e));
    //in room links
    graph.addUndirectedEdge(o204j, r204j, MGraph.CalcCostBetweenPoints(o204j, r204j));
    graph.addUndirectedEdge(o204c, r204c, MGraph.CalcCostBetweenPoints(o204c, r204c));
    graph.addUndirectedEdge(o204d, r204d, MGraph.CalcCostBetweenPoints(o204d, r204d));
    graph.addUndirectedEdge(o204e, r204e, MGraph.CalcCostBetweenPoints(o204e, r204e));
    graph.addUndirectedEdge(o204f, r204f, MGraph.CalcCostBetweenPoints(o204f, r204f));
    graph.addUndirectedEdge(o204g, r204g, MGraph.CalcCostBetweenPoints(o204g, r204g));
    graph.addUndirectedEdge(o204h, r204h, MGraph.CalcCostBetweenPoints(o204h, r204h));
    //connection to 203j
    graph.addUndirectedEdge(o204c, r203j, MGraph.CalcCostBetweenPoints(o204c, r203j) + 10); //Add a little extra weight to give precendence to the southeast entrance.

    //203 suite.
    //inner links
    graph.addUndirectedEdge(ocfrs, o203b, MGraph.CalcCostBetweenPoints(ocfrs, o203b));
    graph.addUndirectedEdge(ocfrs, o203c, MGraph.CalcCostBetweenPoints(ocfrs, o203c));
    graph.addUndirectedEdge(ocfrs, o203e, MGraph.CalcCostBetweenPoints(ocfrs, o203e));
    //from 203b
    graph.addUndirectedEdge(o203b, o203c, MGraph.CalcCostBetweenPoints(o203b, o203c));
    graph.addUndirectedEdge(o203b, o203h, MGraph.CalcCostBetweenPoints(o203b, o203h));
    graph.addUndirectedEdge(o203b, o203g, MGraph.CalcCostBetweenPoints(o203b, o203g));
    graph.addUndirectedEdge(o203b, o203f, MGraph.CalcCostBetweenPoints(o203b, o203f));
    graph.addUndirectedEdge(o203b, o203e, MGraph.CalcCostBetweenPoints(o203b, o203e));
    //from 203e
    graph.addUndirectedEdge(o203e, o203d, MGraph.CalcCostBetweenPoints(o203e, o203d));
    graph.addUndirectedEdge(o203e, o203f, MGraph.CalcCostBetweenPoints(o203e, o203f));
    graph.addUndirectedEdge(o203e, o203g, MGraph.CalcCostBetweenPoints(o203e, o203g));
    graph.addUndirectedEdge(o203e, o203h, MGraph.CalcCostBetweenPoints(o203e, o203h));
    graph.addUndirectedEdge(o203e, o203b, MGraph.CalcCostBetweenPoints(o203e, o203b));
    //from 203c
    graph.addUndirectedEdge(o203c, o203h, MGraph.CalcCostBetweenPoints(o203c, o203h));
    graph.addUndirectedEdge(o203c, o203g, MGraph.CalcCostBetweenPoints(o203c, o203g));
    graph.addUndirectedEdge(o203c, o203f, MGraph.CalcCostBetweenPoints(o203c, o203f));

    //in room links
    graph.addUndirectedEdge(o203b, r203b, MGraph.CalcCostBetweenPoints(o203b, r203b));
    graph.addUndirectedEdge(o203c, r203c, MGraph.CalcCostBetweenPoints(o203c, r203c));
    graph.addUndirectedEdge(o203d, r203d, MGraph.CalcCostBetweenPoints(o203d, r203d));
    graph.addUndirectedEdge(o203e, r203e, MGraph.CalcCostBetweenPoints(o203e, r203e));
    graph.addUndirectedEdge(o203f, r203f, MGraph.CalcCostBetweenPoints(o203f, r203f));
    graph.addUndirectedEdge(o203g, r203g, MGraph.CalcCostBetweenPoints(o203g, r203g));
    graph.addUndirectedEdge(o203h, r203h, MGraph.CalcCostBetweenPoints(o203h, r203h));
    //link into 203j
    graph.addUndirectedEdge(o203h, r203j, MGraph.CalcCostBetweenPoints(o203h, r203j));

    //230 Suite
    //inner links
    graph.addUndirectedEdge(e, o230b, MGraph.CalcCostBetweenPoints(e, o230b));
    graph.addUndirectedEdge(o230b, o230c, MGraph.CalcCostBetweenPoints(o230b, o230c));
    graph.addUndirectedEdge(o230c, o230e, MGraph.CalcCostBetweenPoints(o230c, o230e));
    graph.addUndirectedEdge(o230e, o230g, MGraph.CalcCostBetweenPoints(o230e, o230g));
    graph.addUndirectedEdge(o230g, o230f, MGraph.CalcCostBetweenPoints(o230g, o230f));
    graph.addUndirectedEdge(o230f, o230h, MGraph.CalcCostBetweenPoints(o230f, o230h));
    graph.addUndirectedEdge(o230h, o203d, MGraph.CalcCostBetweenPoints(o230h, o203d));
    //outerlinks
    graph.addUndirectedEdge(e, o230c, MGraph.CalcCostBetweenPoints(e, o230c));
    graph.addUndirectedEdge(o230c, o230g, MGraph.CalcCostBetweenPoints(o230c, o230g));
    graph.addUndirectedEdge(o230c, o230f, MGraph.CalcCostBetweenPoints(o230c, o230f));
    graph.addUndirectedEdge(o230c, o230h, MGraph.CalcCostBetweenPoints(o230c, o230h));
    graph.addUndirectedEdge(o230c, o203d, MGraph.CalcCostBetweenPoints(o230c, o203d));
    graph.addUndirectedEdge(o230c, o203e, MGraph.CalcCostBetweenPoints(o230c, o203e));

    graph.addUndirectedEdge(o203e, o230h, MGraph.CalcCostBetweenPoints(o203e, o230h));
    graph.addUndirectedEdge(o203e, o230f, MGraph.CalcCostBetweenPoints(o203e, o230f));
    graph.addUndirectedEdge(o203e, o230g, MGraph.CalcCostBetweenPoints(o203e, o230g));
    graph.addUndirectedEdge(o203e, o230e, MGraph.CalcCostBetweenPoints(o203e, o230e));
    //inroom links
    graph.addUndirectedEdge(o230b, r230b, MGraph.CalcCostBetweenPoints(o230b, r230b));
    graph.addUndirectedEdge(o230c, r230c, MGraph.CalcCostBetweenPoints(o230c, r230c));
    graph.addUndirectedEdge(o230c, r230d, MGraph.CalcCostBetweenPoints(o230c, r230d));
    graph.addUndirectedEdge(o230e, r230e, MGraph.CalcCostBetweenPoints(o230e, r230e));
    graph.addUndirectedEdge(o230g, r230g, MGraph.CalcCostBetweenPoints(o230g, r230g));
    graph.addUndirectedEdge(o230f, r230f, MGraph.CalcCostBetweenPoints(o230f, r230f));
    graph.addUndirectedEdge(o230h, r230h, MGraph.CalcCostBetweenPoints(o230h, r230h));
    graph.addUndirectedEdge(o230h, r230j, MGraph.CalcCostBetweenPoints(o230h, r230j));

    //206suite
    //inner linkg
    graph.addUndirectedEdge(c, o206b, MGraph.CalcCostBetweenPoints(c, o206b));
    graph.addUndirectedEdge(o206b, o206c, MGraph.CalcCostBetweenPoints(o206b, o206c));
    graph.addUndirectedEdge(o206c, o204g, MGraph.CalcCostBetweenPoints(o206c, o204g));
    //outer
    graph.addUndirectedEdge(c, o206c, MGraph.CalcCostBetweenPoints(c, o206c));
    graph.addUndirectedEdge(c, o204g, MGraph.CalcCostBetweenPoints(c, o204g));
    graph.addUndirectedEdge(c, o204f, MGraph.CalcCostBetweenPoints(c, o204f));

    graph.addUndirectedEdge(o204f, o206c, MGraph.CalcCostBetweenPoints(o204f, o206c));
    graph.addUndirectedEdge(o204f, o206b, MGraph.CalcCostBetweenPoints(o204f, o206b));
    //inroom
    graph.addUndirectedEdge(o206b, r206b, MGraph.CalcCostBetweenPoints(o206b, r206b));
    graph.addUndirectedEdge(o206b, r206e, MGraph.CalcCostBetweenPoints(o206b, r206e));
    graph.addUndirectedEdge(o206c, r206c, MGraph.CalcCostBetweenPoints(o206b, r206c));
    graph.addUndirectedEdge(o206c, r206d, MGraph.CalcCostBetweenPoints(o206b, r206d));

    //nw hall
    //inner loops
    graph.addUndirectedEdge(d, o2070, MGraph.CalcCostBetweenPoints(d, o2070));
    graph.addUndirectedEdge(o2070, o2080, MGraph.CalcCostBetweenPoints(o2070, o2080));
    graph.addUndirectedEdge(o2080, o213a, MGraph.CalcCostBetweenPoints(o2080, o213a));
    graph.addUndirectedEdge(o213a, o2140, MGraph.CalcCostBetweenPoints(o213a, o2140));
    graph.addUndirectedEdge(o2140, o215a, MGraph.CalcCostBetweenPoints(o2140, o215a));

    //outer loop right
    graph.addDirectedEdge(o215a, o2140, MGraph.CalcCostBetweenPoints(o215a, o2140));
    graph.addDirectedEdge(o215a, o213a, MGraph.CalcCostBetweenPoints(o215a, o213a));
    graph.addDirectedEdge(o215a, o2090, MGraph.CalcCostBetweenPoints(o215a, o2090));
    graph.addDirectedEdge(o215a, o2080, MGraph.CalcCostBetweenPoints(o215a, o2080));
    graph.addDirectedEdge(o215a, o2070, MGraph.CalcCostBetweenPoints(o215a, o2070));
    //outer loop left
    graph.addDirectedEdge(d, o2070, MGraph.CalcCostBetweenPoints(d, o2070));
    graph.addDirectedEdge(d, o2080, MGraph.CalcCostBetweenPoints(d, o2080));
    graph.addDirectedEdge(d, o2090, MGraph.CalcCostBetweenPoints(d, o2090));
    graph.addDirectedEdge(d, o213a, MGraph.CalcCostBetweenPoints(d, o213a));
    graph.addDirectedEdge(d, o2140, MGraph.CalcCostBetweenPoints(d, o2140));
    //outer loop
    graph.addUndirectedEdge(a, d, MGraph.CalcCostBetweenPoints(a, d));
    graph.addUndirectedEdge(c, d, MGraph.CalcCostBetweenPoints(c, d));
    graph.addUndirectedEdge(a, o215a, MGraph.CalcCostBetweenPoints(a, o215a));
    graph.addUndirectedEdge(d, o215a, MGraph.CalcCostBetweenPoints(d, o215a));
    //in room 
    graph.addDirectedEdge(o215a, r215a, MGraph.CalcCostBetweenPoints(o215a, r215a));
    graph.addDirectedEdge(o2140, r2140, MGraph.CalcCostBetweenPoints(o2140, r2140));
    graph.addDirectedEdge(o213a, r213a, MGraph.CalcCostBetweenPoints(o213a, r213a));
    graph.addDirectedEdge(o213a, f, MGraph.CalcCostBetweenPoints(o213a, f));
    graph.addDirectedEdge(f, r215b, MGraph.CalcCostBetweenPoints(o213a, r215b));
    graph.addDirectedEdge(r215b, r215d, MGraph.CalcCostBetweenPoints(r215b, r215d));

    graph.addDirectedEdge(o2090, r2090, MGraph.CalcCostBetweenPoints(o2090, r2090));
    graph.addDirectedEdge(o2080, r2080, MGraph.CalcCostBetweenPoints(o2080, r2080));
    graph.addDirectedEdge(o2070, r2070, MGraph.CalcCostBetweenPoints(o2070, r2070));

    //sw hall.
    graph.addUndirectedEdge(o215a, g, MGraph.CalcCostBetweenPoints(o215a, g));
    graph.addUndirectedEdge(h, g, MGraph.CalcCostBetweenPoints(h, g));
    graph.addUndirectedEdge(o215a, h, MGraph.CalcCostBetweenPoints(o215a, h));

    //219 suite
    graph.addUndirectedEdge(o219f, g, MGraph.CalcCostBetweenPoints(o219f, g));
    graph.addUndirectedEdge(g, r219f, MGraph.CalcCostBetweenPoints(g, r219f));
    //outer direct se
    graph.addUndirectedEdge(o219f, r219g, MGraph.CalcCostBetweenPoints(o219f, r219g));
    graph.addUndirectedEdge(o219f, o219h, MGraph.CalcCostBetweenPoints(o219f, o219h));
    graph.addUndirectedEdge(o219f, r219i, MGraph.CalcCostBetweenPoints(o219f, r219i));
    //outer direct ne
    graph.addUndirectedEdge(o219f, r219a, MGraph.CalcCostBetweenPoints(o219f, r219a));
    graph.addUndirectedEdge(o219f, o219e, MGraph.CalcCostBetweenPoints(o219f, o219e));
    graph.addUndirectedEdge(o219f, o219d, MGraph.CalcCostBetweenPoints(o219f, o219d));
    graph.addUndirectedEdge(o219f, o219c, MGraph.CalcCostBetweenPoints(o219f, o219c));
    graph.addUndirectedEdge(o219f, r219b, MGraph.CalcCostBetweenPoints(o219f, r219b));
    //inner loops se.   
    graph.addUndirectedEdge(r219g, o219h, MGraph.CalcCostBetweenPoints(r219g, o219h));
    graph.addUndirectedEdge(o219h, r219i, MGraph.CalcCostBetweenPoints(o219h, r219i));
    //inner loops ne
    graph.addUndirectedEdge(r219a, o219e, MGraph.CalcCostBetweenPoints(r219a, o219e));
    graph.addUndirectedEdge(o219e, o219d, MGraph.CalcCostBetweenPoints(o219e, o219d));
    graph.addUndirectedEdge(o219d, o219c, MGraph.CalcCostBetweenPoints(o219d, o219c));
    graph.addUndirectedEdge(o219c, r219b, MGraph.CalcCostBetweenPoints(o219c, r219b));
    //in room links
    graph.addUndirectedEdge(o219c, r219c, MGraph.CalcCostBetweenPoints(o219c, r219c));
    graph.addUndirectedEdge(o219d, r219d, MGraph.CalcCostBetweenPoints(o219d, r219d));
    graph.addUndirectedEdge(o219e, r219e, MGraph.CalcCostBetweenPoints(o219e, r219e));
    graph.addUndirectedEdge(o219f, r219f, MGraph.CalcCostBetweenPoints(o219f, r219f));
    graph.addUndirectedEdge(o219h, r219h, MGraph.CalcCostBetweenPoints(o219h, r219h));

    return graph;
}

MapPoints.GetThirdFloor = function () {
    var graph = new MGraph.Graph();
    graph.label = "Third Floor";
    var ne0 = 830; //inside 302 suite
    var ne1 = 801; //outside 302Suite
    var ne2 = 675; //elevator hall

    var nw1 = 125; //inside offices nw
    var nw2 = 160; //304 hall line
    var nw3 = 163; //nw hall line

    var se1 = 540; //inside offices se
    var se2 = 516; //335suite hall
    var se3 = 510; //se hall line

    var sw1 = 72; //inside 318 suite.
    var sw2 = 110; //outside 318 suite.
    var sw3 = 180; //sw hallway

    var elevator = new MGraph.Point(ne2, 340, "Elevator");
    var a = new MGraph.Point(ne2, nw2, "a");
    var b = new MGraph.Point(ne2, nw3, "b");
    var c = new MGraph.Point(ne2, se3, "c");
    var d = new MGraph.Point(ne2, se2, "d");

    var e = new MGraph.Point(sw3, nw2, "e");
    var f = new MGraph.Point(sw3, nw3, "f");
    var g = new MGraph.Point(sw3, se3, "g");
    var h = new MGraph.Point(sw3, se2, "h");
    var mens = new MGraph.Point(580, se3, "mens1");
    var mens2 = new MGraph.Point(580, se3-50, "mens");
    var ladies = new MGraph.Point(510, nw3, "ladies1");
    var ladies2 = new MGraph.Point(510, 197, "ladies2");
    var ladies3 = new MGraph.Point(600, 197, "ladies");

    //302 suite
    //outside doors
    var o302c = new MGraph.Point(ne1, 434, "o302c");
    var o302d = new MGraph.Point(ne1, 406, "o302d");
    var o302e = new MGraph.Point(ne1, 351, "o302e");
    var o302f = new MGraph.Point(ne1, 268, "o302f");
    var o302g = new MGraph.Point(ne1, 242, "o302g");
    //inside doors
    var r302c = new MGraph.Point(ne0, 434, "302C");
    var r302d = new MGraph.Point(ne0, 406, "302D");
    var r302e = new MGraph.Point(ne0, 351, "302E");
    var r302f = new MGraph.Point(ne0, 268, "302F");
    var r302g = new MGraph.Point(ne0, 242, "302G");
    //304 Suite
    var o304b = new MGraph.Point(745, nw2, "o304B");
    var o304c = new MGraph.Point(ne1, nw2, "o304C");
    //var o304d = new MGraph.Point(0, nw2, "o304D");
    var o304e = new MGraph.Point(ne1 + 1, nw2, "o304E"); //add 1 to prevent blackholing with 304c
    var o304f = new MGraph.Point(771, nw2, "o304F");

    var r304b = new MGraph.Point(745, 185, "304B");
    var r304c = new MGraph.Point(ne1, 185, "304C");
    var r304d = new MGraph.Point(ne0, nw2, "304D");
    var r304e = new MGraph.Point(ne1, nw1, "304E");
    var r304f = new MGraph.Point(771, nw1, "304F");

    //335 Suite   
    var o335b = new MGraph.Point(768, se2, "o335B");
    var o335c = new MGraph.Point(ne1 + 1, se2, "o335C"); //add 1 to prevent blackholing with 335e
    //var o335d = new MGraph.Point(0, nw2, "o335D");
    var o335e = new MGraph.Point(ne1, se2, "o335E");
    var o335f = new MGraph.Point(740, se2, "o335F");

    var r335b = new MGraph.Point(768, se1, "335B");
    var r335c = new MGraph.Point(ne1, se1, "335C");
    var r335d = new MGraph.Point(ne0, se2, "335D");
    var r335e = new MGraph.Point(ne1, 490, "335E");
    var r335f = new MGraph.Point(740, 490, "335F");
    //NW Hall
    var o3060 = new MGraph.Point(661, nw3, "o3060");
    var o3070 = new MGraph.Point(631, nw3, "o3070");
    var o3080 = new MGraph.Point(549, nw3, "o3080");
    var o3090 = new MGraph.Point(524, nw3, "o3090");
    var o3110 = new MGraph.Point(382, nw3, "o3110");
    var o3120 = new MGraph.Point(356, nw3, "o3120");
    var o3130 = new MGraph.Point(274, nw3, "o3130");
    var o3140 = new MGraph.Point(246, nw3, "o3140");

    var r3060 = new MGraph.Point(661, nw1, "3060");
    var r3070 = new MGraph.Point(631, nw1, "3070");
    var r3080 = new MGraph.Point(549, nw1, "3080");
    var r3090 = new MGraph.Point(524, nw1, "3090");
    var r3110 = new MGraph.Point(382, nw1, "3110");
    var r3120 = new MGraph.Point(356, nw1, "3120");
    var r3130 = new MGraph.Point(274, nw1, "3130");
    var r3140 = new MGraph.Point(246, nw1, "3140");

    //SE Hall
    var o3330 = new MGraph.Point(660, se3, "o3330");
    var o3320 = new MGraph.Point(632, se3, "o3320");
    var o3300 = new MGraph.Point(548, se3, "o3300");
    var o3290 = new MGraph.Point(522, se3, "o3290");
    var o3280 = new MGraph.Point(385, se3, "o3280");
    var o3270 = new MGraph.Point(355, se3, "o3270");
    var o3250 = new MGraph.Point(271, se3, "o3250");
    var o3240 = new MGraph.Point(245, se3, "o3240");

    var r3330 = new MGraph.Point(660, se1, "3330");
    var r3320 = new MGraph.Point(632, se1, "3320");
    var r3300 = new MGraph.Point(548, se1, "3300");
    var r3290 = new MGraph.Point(522, se1, "3290");
    var r3280 = new MGraph.Point(385, se1, "3280");
    var r3270 = new MGraph.Point(355, se1, "3270");
    var r3250 = new MGraph.Point(271, se1, "3250");
    var r3240 = new MGraph.Point(245, se1, "3240");
    //SW Hall
    //315 Suite    
    var o315e = new MGraph.Point(107, nw2, "o315E");
    var o315c = new MGraph.Point(108, nw2, "o315C");
    var o315b = new MGraph.Point(132, nw2, "o315B");

    var r315e = new MGraph.Point(107, nw2 + 30, "315E");
    var r315d = new MGraph.Point(sw1, nw2, "315D");
    var r315c = new MGraph.Point(108, nw1, "315C");
    var r315b = new MGraph.Point(132, nw1, "315B");
    //322 Suite
    var o322e = new MGraph.Point(136, se2, "o322E");
    var o322d = new MGraph.Point(108, se2, "o322D");
    //var r322c = new MGraph.Point(245, se1, "322c");
    var o322b = new MGraph.Point(107, se2, "o322B");

    var r322e = new MGraph.Point(136, se1, "322E");
    var r322d = new MGraph.Point(108, se1, "322D");
    var r322c = new MGraph.Point(sw1, se2, "322C");
    var r322b = new MGraph.Point(107, se1 - 50, "322B");
    //318 Suite
    var o318a = new MGraph.Point(sw3, 275, "o318A");
    var r318a = new MGraph.Point(sw2 + 30, 275, "318A");
    var o318x = new MGraph.Point(sw3, 405, "o318X"); //outside 318d
    var r318x = new MGraph.Point(sw2 + 30, 405, "318X");
    
    var o318e = new MGraph.Point(sw1 + 35, 435, "o318E");
    var r318e = new MGraph.Point(sw1, 435, "318E");
    
    var o318d = new MGraph.Point(sw1 + 35, 405, "o318D");
    var r318d = new MGraph.Point(sw1, 405, "318D");

    var o318b = new MGraph.Point(sw1 + 35, 243, "o318B");
    var r318b = new MGraph.Point(sw1, 243, "318B");

    var o318c = new MGraph.Point(sw1 + 35, 271, "o318c");
    var r318c = new MGraph.Point(sw1, 271, "318C");


    graph.addNodeByValue(elevator);
    //elevator hall
    graph.addNodesByValue([a, b, c, d, e, f, g, h, mens, ladies, ladies2, ladies3]);
    //302 suite.
    graph.addNodesByValue([r302c, r302d, r302e, r302f, r302g, o302c, o302d, o302e, o302f, o302g]);
    //304 suite.
    graph.addNodesByValue([r304b, r304c, r304d, r304e, r304f, o304b, o304c, o304e, o304f]);
    //335 suite.
    graph.addNodesByValue([r335b, r335c, r335d, r335e, r335f, o335b, o335c, o335e, o335f]);
    //NW Hall
    graph.addNodesByValue([r3060, r3070, r3080, r3090, r3110, r3120, r3130, r3140, o3060, o3070, o3080, o3090, o3110, o3120, o3130, o3140]);
    //SE Hall
    graph.addNodesByValue([r3330, r3320, r3300, r3290, r3280, r3270, r3250, r3240, o3330, o3320, o3300, o3290, o3280, o3270, o3250, o3240]);
    //315 suite
    graph.addNodesByValue([o315e, o315c, o315b, r315e, r315d, r315c, r315b]);
    //322 Suite
    graph.addNodesByValue([o322e, o322d, o322b, r322e, r322d, r322c, r322b]);
    //318 suite
    graph.addNodesByValue([o318a, r318a, o318x, r318x, o318d, r318d, o318e, r318e, o318b, r318b, o318c, r318c]);
    //elevator hall
    graph.addUndirectedEdge(elevator, a, MGraph.CalcCostBetweenPoints(elevator, a));
    graph.addUndirectedEdge(elevator, b, MGraph.CalcCostBetweenPoints(elevator, b));
    graph.addUndirectedEdge(elevator, c, MGraph.CalcCostBetweenPoints(elevator, c));
    graph.addUndirectedEdge(elevator, d, MGraph.CalcCostBetweenPoints(elevator, d));
    graph.addUndirectedEdge(a, b, MGraph.CalcCostBetweenPoints(a, b));
    graph.addUndirectedEdge(c, d, MGraph.CalcCostBetweenPoints(c, d));

    //302 suite    
    graph.addUndirectedEdge(elevator, o302d, MGraph.CalcCostBetweenPoints(elevator, o302d));
    graph.addUndirectedEdge(elevator, o302e, MGraph.CalcCostBetweenPoints(elevator, o302e));
    graph.addUndirectedEdge(elevator, o302f, MGraph.CalcCostBetweenPoints(elevator, o302f));
    //links to closet areas
    graph.addUndirectedEdge(o302f, o302g, MGraph.CalcCostBetweenPoints(o302f, o302g));
    graph.addUndirectedEdge(o302d, o302c, MGraph.CalcCostBetweenPoints(o302d, o302c));
    //links inside offices.
    graph.addDirectedEdge(o302g, r302g, MGraph.CalcCostBetweenPoints(o302g, r302g));
    graph.addDirectedEdge(o302f, r302f, MGraph.CalcCostBetweenPoints(o302f, r302f));
    graph.addDirectedEdge(o302e, r302e, MGraph.CalcCostBetweenPoints(o302e, r302e));
    graph.addDirectedEdge(o302d, r302d, MGraph.CalcCostBetweenPoints(o302d, r302d));
    graph.addDirectedEdge(o302c, r302c, MGraph.CalcCostBetweenPoints(o302c, r302c));

    //304 Suite
    //inner links
    graph.addUndirectedEdge(a, o304b, MGraph.CalcCostBetweenPoints(a, o304b));
    graph.addUndirectedEdge(o304b, o304f, MGraph.CalcCostBetweenPoints(o304b, o304f));
    graph.addUndirectedEdge(o304f, o304c, MGraph.CalcCostBetweenPoints(o304f, o304c));
    graph.addUndirectedEdge(o304c, o304e, MGraph.CalcCostBetweenPoints(o304c, o304e));
    graph.addUndirectedEdge(o304e, r304d, MGraph.CalcCostBetweenPoints(o304e, r304d));
    //outer links
    graph.addUndirectedEdge(a, o304f, MGraph.CalcCostBetweenPoints(a, o304f));
    graph.addUndirectedEdge(a, o304c, MGraph.CalcCostBetweenPoints(a, o304c));
    graph.addUndirectedEdge(a, o304e, MGraph.CalcCostBetweenPoints(a, o304e));
    graph.addUndirectedEdge(a, r304d, MGraph.CalcCostBetweenPoints(a, r304d));
    //inside office links
    graph.addDirectedEdge(o304b, r304b, MGraph.CalcCostBetweenPoints(o304b, r304b));
    graph.addDirectedEdge(o304f, r304f, MGraph.CalcCostBetweenPoints(o304f, r304f));
    graph.addDirectedEdge(o304c, r304c, MGraph.CalcCostBetweenPoints(o304c, r304c));
    graph.addDirectedEdge(o304e, r304e, MGraph.CalcCostBetweenPoints(o304e, r304e));

    //335 Suite
    //inner links
    graph.addUndirectedEdge(d, o335f, MGraph.CalcCostBetweenPoints(d, o335f));
    graph.addUndirectedEdge(o335f, o335b, MGraph.CalcCostBetweenPoints(o335f, o335b));
    graph.addUndirectedEdge(o335b, o335e, MGraph.CalcCostBetweenPoints(o335b, o335e));
    graph.addUndirectedEdge(o335e, o335c, MGraph.CalcCostBetweenPoints(o335e, o335c));
    graph.addUndirectedEdge(o335c, r335d, MGraph.CalcCostBetweenPoints(o335c, r335d));
    //outer links
    graph.addUndirectedEdge(d, o335b, MGraph.CalcCostBetweenPoints(d, o335b));
    graph.addUndirectedEdge(d, o335c, MGraph.CalcCostBetweenPoints(d, o335c));
    graph.addUndirectedEdge(d, o335e, MGraph.CalcCostBetweenPoints(d, o335e));
    graph.addUndirectedEdge(d, r335d, MGraph.CalcCostBetweenPoints(d, r335d));
    //inside office links
    graph.addDirectedEdge(o335b, r335b, MGraph.CalcCostBetweenPoints(o335b, r335b));
    graph.addDirectedEdge(o335f, r335f, MGraph.CalcCostBetweenPoints(o335f, r335f));
    graph.addDirectedEdge(o335c, r335c, MGraph.CalcCostBetweenPoints(o335c, r335c));
    graph.addDirectedEdge(o335e, r335e, MGraph.CalcCostBetweenPoints(o335e, r335e));
    //NW Hall
    //whole hall jump
    graph.addUndirectedEdge(b, e, MGraph.CalcCostBetweenPoints(b, e));
    graph.addUndirectedEdge(b, f, MGraph.CalcCostBetweenPoints(b, f));
    //inner loops
    graph.addUndirectedEdge(b, o3060, MGraph.CalcCostBetweenPoints(b, o3060));
    graph.addUndirectedEdge(o3060, o3070, MGraph.CalcCostBetweenPoints(o3060, o3070));   
    graph.addUndirectedEdge(o3070, o3080, MGraph.CalcCostBetweenPoints(o3070, o3080));
    graph.addUndirectedEdge(o3080, o3090, MGraph.CalcCostBetweenPoints(o3080, o3090));
    graph.addUndirectedEdge(o3090, ladies3, MGraph.CalcCostBetweenPoints(o3090, ladies3));
    graph.addUndirectedEdge(ladies3, o3110, MGraph.CalcCostBetweenPoints(ladies3, o3110));
    graph.addUndirectedEdge(o3110, o3120, MGraph.CalcCostBetweenPoints(o3110, o3120));
    graph.addUndirectedEdge(o3120, o3130, MGraph.CalcCostBetweenPoints(o3120, o3130));
    graph.addUndirectedEdge(o3130, o3140, MGraph.CalcCostBetweenPoints(o3130, o3140));
    graph.addUndirectedEdge(o3140, f, MGraph.CalcCostBetweenPoints(o3140, f));
    //outerlinks
    graph.addUndirectedEdge(b, o3070, MGraph.CalcCostBetweenPoints(b, o3070));
    graph.addUndirectedEdge(b, o3080, MGraph.CalcCostBetweenPoints(b, o3080));
    graph.addUndirectedEdge(b, o3090, MGraph.CalcCostBetweenPoints(b, o3090));
    graph.addUndirectedEdge(b, ladies3, MGraph.CalcCostBetweenPoints(b, ladies3));
    graph.addUndirectedEdge(b, o3110, MGraph.CalcCostBetweenPoints(b, o3110));
    graph.addUndirectedEdge(b, o3120, MGraph.CalcCostBetweenPoints(b, o3120));
    graph.addUndirectedEdge(b, o3130, MGraph.CalcCostBetweenPoints(b, o3130));
    graph.addUndirectedEdge(b, o3140, MGraph.CalcCostBetweenPoints(b, o3140));
    graph.addUndirectedEdge(f, o3130, MGraph.CalcCostBetweenPoints(f, o3130));
    graph.addUndirectedEdge(f, o3120, MGraph.CalcCostBetweenPoints(f, o3120));
    graph.addUndirectedEdge(f, o3110, MGraph.CalcCostBetweenPoints(f, o3110));
    graph.addUndirectedEdge(f, ladies3, MGraph.CalcCostBetweenPoints(f, ladies3));
    graph.addUndirectedEdge(f, o3090, MGraph.CalcCostBetweenPoints(f, o3090));
    graph.addUndirectedEdge(f, o3080, MGraph.CalcCostBetweenPoints(f, o3080));
    graph.addUndirectedEdge(f, o3070, MGraph.CalcCostBetweenPoints(f, o3070));
    graph.addUndirectedEdge(f, o3060, MGraph.CalcCostBetweenPoints(f, o3060));
    //inside office links.
    graph.addDirectedEdge(o3060, r3060, MGraph.CalcCostBetweenPoints(o3060, r3060));
    graph.addDirectedEdge(o3070, r3070, MGraph.CalcCostBetweenPoints(o3070, r3070));
    graph.addDirectedEdge(o3080, r3080, MGraph.CalcCostBetweenPoints(o3080, r3080));
    graph.addDirectedEdge(o3090, r3090, MGraph.CalcCostBetweenPoints(o3090, r3090));
    graph.addDirectedEdge(o3110, r3110, MGraph.CalcCostBetweenPoints(o3110, r3110));
    graph.addDirectedEdge(o3120, r3120, MGraph.CalcCostBetweenPoints(o3120, r3120));
    graph.addDirectedEdge(o3130, r3130, MGraph.CalcCostBetweenPoints(o3130, r3130));
    graph.addDirectedEdge(o3140, r3140, MGraph.CalcCostBetweenPoints(o3140, r3140));
    graph.addDirectedEdge(ladies3, ladies2, MGraph.CalcCostBetweenPoints(ladies3, ladies2));
    graph.addDirectedEdge(ladies2, ladies, MGraph.CalcCostBetweenPoints(ladies2, ladies));
    //SE Hall
    //whole hall jump
    graph.addUndirectedEdge(c, g, MGraph.CalcCostBetweenPoints(c, g));
    graph.addUndirectedEdge(c, h, MGraph.CalcCostBetweenPoints(c, h));
    //inner loops
    graph.addUndirectedEdge(c, o3330, MGraph.CalcCostBetweenPoints(d, o3330));
    graph.addUndirectedEdge(o3330, o3320, MGraph.CalcCostBetweenPoints(o3330, o3320));
    graph.addUndirectedEdge(o3320, mens, MGraph.CalcCostBetweenPoints(o3320, mens));
    graph.addUndirectedEdge(mens, o3300, MGraph.CalcCostBetweenPoints(mens, o3300));
    graph.addUndirectedEdge(o3300, o3290, MGraph.CalcCostBetweenPoints(o3300, o3290));
    graph.addUndirectedEdge(o3290, o3280, MGraph.CalcCostBetweenPoints(o3290, o3280));
    graph.addUndirectedEdge(o3280, o3270, MGraph.CalcCostBetweenPoints(o3280, o3270));
    graph.addUndirectedEdge(o3270, o3250, MGraph.CalcCostBetweenPoints(o3270, o3250));
    graph.addUndirectedEdge(o3250, o3240, MGraph.CalcCostBetweenPoints(o3250, o3240));   
    graph.addUndirectedEdge(o3240, g, MGraph.CalcCostBetweenPoints(o3240, g));
    //outerlinks
    graph.addUndirectedEdge(c, o3320, MGraph.CalcCostBetweenPoints(c, o3320));
    graph.addUndirectedEdge(c, mens, MGraph.CalcCostBetweenPoints(c, mens));
    graph.addUndirectedEdge(c, o3300, MGraph.CalcCostBetweenPoints(c, o3300));
    graph.addUndirectedEdge(c, o3290, MGraph.CalcCostBetweenPoints(c, o3290));
    graph.addUndirectedEdge(c, o3280, MGraph.CalcCostBetweenPoints(c, o3280));
    graph.addUndirectedEdge(c, o3270, MGraph.CalcCostBetweenPoints(c, o3270));    
    graph.addUndirectedEdge(c, o3250, MGraph.CalcCostBetweenPoints(c, o3250));
    graph.addUndirectedEdge(c, o3240, MGraph.CalcCostBetweenPoints(c, o3240));
    graph.addUndirectedEdge(g, o3250, MGraph.CalcCostBetweenPoints(g, o3250));
    graph.addUndirectedEdge(g, o3270, MGraph.CalcCostBetweenPoints(g, o3270));
    graph.addUndirectedEdge(g, o3280, MGraph.CalcCostBetweenPoints(g, o3280));
    graph.addUndirectedEdge(g, o3290, MGraph.CalcCostBetweenPoints(g, o3290));
    graph.addUndirectedEdge(g, o3300, MGraph.CalcCostBetweenPoints(g, o3300));
    graph.addUndirectedEdge(g, mens, MGraph.CalcCostBetweenPoints(g, mens));
    graph.addUndirectedEdge(g, o3320, MGraph.CalcCostBetweenPoints(g, o3320));
    graph.addUndirectedEdge(g, o3330, MGraph.CalcCostBetweenPoints(g, o3330));
    //inside office links.
    graph.addDirectedEdge(o3330, r3330, MGraph.CalcCostBetweenPoints(o3330, r3330));
    graph.addDirectedEdge(o3320, r3320, MGraph.CalcCostBetweenPoints(o3320, r3320));
    graph.addDirectedEdge(o3300, r3300, MGraph.CalcCostBetweenPoints(o3300, r3300));
    graph.addDirectedEdge(o3290, r3290, MGraph.CalcCostBetweenPoints(o3290, r3290));
    graph.addDirectedEdge(o3280, r3280, MGraph.CalcCostBetweenPoints(o3280, r3280));
    graph.addDirectedEdge(o3270, r3270, MGraph.CalcCostBetweenPoints(o3270, r3270));
    graph.addDirectedEdge(o3250, r3250, MGraph.CalcCostBetweenPoints(o3250, r3250));
    graph.addDirectedEdge(o3240, r3240, MGraph.CalcCostBetweenPoints(o3240, r3240));
    graph.addDirectedEdge(mens, mens2, MGraph.CalcCostBetweenPoints(mens, mens2));
    //SW Hall
    //inner links
    graph.addUndirectedEdge(e, f, MGraph.CalcCostBetweenPoints(e, f));
    graph.addUndirectedEdge(f, o318a, MGraph.CalcCostBetweenPoints(g, o318a));
    graph.addUndirectedEdge(o318a, o318x, MGraph.CalcCostBetweenPoints(o318a, o318x));
    graph.addUndirectedEdge(o318x, g, MGraph.CalcCostBetweenPoints(o318x, g));
    graph.addUndirectedEdge(g, h, MGraph.CalcCostBetweenPoints(g, h));
    //outer links    
    graph.addUndirectedEdge(f, h, MGraph.CalcCostBetweenPoints(f, h));
    graph.addUndirectedEdge(f, o318x, MGraph.CalcCostBetweenPoints(f, o318x));
    graph.addUndirectedEdge(g, e, MGraph.CalcCostBetweenPoints(g, e));
    graph.addUndirectedEdge(g, o318a, MGraph.CalcCostBetweenPoints(g, o318a));
   
    
    //inner links
    graph.addUndirectedEdge(h, o322e, MGraph.CalcCostBetweenPoints(h, o322e));
    graph.addUndirectedEdge(o322e, o322b, MGraph.CalcCostBetweenPoints(o322e, o322b));
    graph.addUndirectedEdge(o322b, o322d, MGraph.CalcCostBetweenPoints(o322b, o322d));
    graph.addUndirectedEdge(o322d, r322c, MGraph.CalcCostBetweenPoints(o322d, r322c));
    //outer links
    graph.addUndirectedEdge(h, o322b, MGraph.CalcCostBetweenPoints(h, o322b));
    graph.addUndirectedEdge(h, o322d, MGraph.CalcCostBetweenPoints(h, o322d));
    //inside offices
    graph.addUndirectedEdge(h, r322c, MGraph.CalcCostBetweenPoints(h, r322c));
    graph.addUndirectedEdge(o322b, r322b, MGraph.CalcCostBetweenPoints(o322b, r322b));
    graph.addUndirectedEdge(o322d, r322d, MGraph.CalcCostBetweenPoints(o322d, r322d));
    graph.addUndirectedEdge(o322e, r322e, MGraph.CalcCostBetweenPoints(o322e, r322e));
   
    //315 Suite
    //inner links
    graph.addUndirectedEdge(e, o315b, MGraph.CalcCostBetweenPoints(e, o315b));
    graph.addUndirectedEdge(o315b, o315e, MGraph.CalcCostBetweenPoints(o315b, o315e));
    graph.addUndirectedEdge(o315e, o315c, MGraph.CalcCostBetweenPoints(o315e, o315c));
    graph.addUndirectedEdge(o315c, r315d, MGraph.CalcCostBetweenPoints(o315c, r315d));
    //outer links
    graph.addUndirectedEdge(e, o315e, MGraph.CalcCostBetweenPoints(e, o315e));
    graph.addUndirectedEdge(e, o315c, MGraph.CalcCostBetweenPoints(e, o315c));
    //inside offices
    graph.addUndirectedEdge(e, r315d, MGraph.CalcCostBetweenPoints(e, r315d));
    graph.addUndirectedEdge(o315b, r315b, MGraph.CalcCostBetweenPoints(o315b, r315b));
    graph.addUndirectedEdge(o315c, r315c, MGraph.CalcCostBetweenPoints(o315c, r315c));
    graph.addUndirectedEdge(o315e, r315e, MGraph.CalcCostBetweenPoints(o315e, r315e));

    //318 Suite
    graph.addUndirectedEdge(o318a, r318a, MGraph.CalcCostBetweenPoints(o318a, r318a));
    graph.addUndirectedEdge(o318x, r318x, MGraph.CalcCostBetweenPoints(o318x, r318x));
    //322 Suite
    //line to 318d
    graph.addUndirectedEdge(o318x, r318d, MGraph.CalcCostBetweenPoints(o318x, r318d));
    //graph.addUndirectedEdge(r318x, o318d, MGraph.CalcCostBetweenPoints(o318x, o318d));
    //graph.addUndirectedEdge(o318d, r318d, MGraph.CalcCostBetweenPoints(o318d, r318d));
    //line to 318e    
    graph.addUndirectedEdge(r318x, o318e, MGraph.CalcCostBetweenPoints(r318x, o318e));
    graph.addUndirectedEdge(o318e, r318e, MGraph.CalcCostBetweenPoints(o318e, r318e));
    //lines inside large suite
    graph.addUndirectedEdge(r318a, o318b, MGraph.CalcCostBetweenPoints(r318a, o318b));
    graph.addUndirectedEdge(o318b, r318b, MGraph.CalcCostBetweenPoints(o318b, r318b));

    graph.addUndirectedEdge(r318a, r318c, MGraph.CalcCostBetweenPoints(r318a, r318c));

    return graph;
}

MapPoints.GetGroundFloor = function () {
    var graph = new MGraph.Graph();
    graph.label = "Ground Floor";
    //ne line x points
    var ne1 = 845; //elevator hallway
    //sw line y
    var sw1 = 148; //vending hallway.

    //nw lines y points
    var nw1 = 228; //inside the LRC
    var nw2 = 325; //inside suite 390, cyber cafe, 44s
    var nw3 = 384; //1st hall going to LRC.
    var nw4 = 718; //noa 280 hallo
    var nw5 = 997; //noa040 hallway
    var nw6 = 1334; //furthest southwest line
    
    //do not confused
    var o44 = 720; //suite 44 hall line. xpoint


    var elevator = new MGraph.Point(ne1, 517, "Elevator");
    var a = new MGraph.Point(ne1, 279, "A");
    var b = new MGraph.Point(ne1, nw3, "B"); //northside intersection near 44 suite.
    var c = new MGraph.Point(sw1, nw3, "C"); //northwest intersection by vending and cyber cafe
    var d = new MGraph.Point(ne1, nw4, "D"); //intersection of 280 and 030
    var e = new MGraph.Point(sw1, nw4, "E"); //intersection of 280 and 030
    var f = new MGraph.Point(ne1, nw5, "F"); //intersection of 280 and 030
    var g = new MGraph.Point(sw1, nw5, "G"); //intersection of 280 and 030
    var h = new MGraph.Point(ne1, nw6, "H"); //southwest exit
    var i = new MGraph.Point(sw1, nw6, "I"); //south exit

    //classrooms in horizontal halls
    var r31a = new MGraph.Point(291, 538, "NOA31A");
    var r300 = new MGraph.Point(500, nw4 - 60, "NOA300");
    var r290 = new MGraph.Point(624, 573, "NOA290");
    var r270 = new MGraph.Point(616, 845, "NOA270");
    var r260 = new MGraph.Point(500, nw4 + 60, "NOA260");
    var r250 = new MGraph.Point(288, 845, "NOA250");
    var r220 = new MGraph.Point(692, nw5 + 60, "NOA220");
    var r210 = new MGraph.Point(619, nw5 + 60, "NOA210");
    var r170 = new MGraph.Point(316, nw5 + 60, "NOA170");

    //elevator hall
    var o30 = new MGraph.Point(ne1, 845, "o30");
    var o40 = new MGraph.Point(ne1, 875, "o40");
    var o50 = new MGraph.Point(ne1, 1060, "o50");
    var o60 = new MGraph.Point(ne1, 1105, "o60");
    var o80 = new MGraph.Point(687, nw6, "o080");

    var r30 = new MGraph.Point(ne1 - 50, 845, "NOA030");
    var r40 = new MGraph.Point(ne1 - 50, 875, "NOA040");
    var r50 = new MGraph.Point(ne1 - 50, 1060, "NOA050");
    var r60 = new MGraph.Point(ne1 - 50, 1105, "NOA060");
    var r80 = new MGraph.Point(629, nw6, "NOA080");
    var r90 = new MGraph.Point(687, nw6 - 50, "NOA090");
    //sw hall
    var o31a = new MGraph.Point(sw1, 441, "o31a"); //intersection of 280 and 030
    var vending = new MGraph.Point(sw1, 482, "Vending"); //Vending
    var o150 = new MGraph.Point(sw1, 1055, "o150"); 
    var o140 = new MGraph.Point(sw1, 1156, "o140"); 
    var o130 = new MGraph.Point(sw1, 1185, "o130");
    var o120 = new MGraph.Point(sw1, 1266, "o120");
    //inside sw classrooms.

    var r31a1 = new MGraph.Point(sw1 + 50, 441, "NOA31A - 1"); 
    var r150 = new MGraph.Point(sw1 + 50, 1055, "NOA150"); 
    var r140 = new MGraph.Point(sw1 + 50, 1156, "NOA140"); 
    var r130 = new MGraph.Point(sw1 + 50, 1185, "NOA130");
    var r120 = new MGraph.Point(sw1 + 50, 1266, "NOA120"); 

    //nw hall 
    var o2901 = new MGraph.Point(555, nw3, "o290 - 1");
    var o390a = new MGraph.Point(464, nw3, "o390a");
    var o380a = new MGraph.Point(378, nw3, "o380a");
    var ocyber = new MGraph.Point(235, nw3, "ocyber");
    var olrc = new MGraph.Point(235, 300, "olrc"); //also outside the womens room
    //LRC Suite
    var cyber = new MGraph.Point(145, 283, "NOA Cyber Cafe");
    var r340a = new MGraph.Point(235, nw1, "NOA340A");
    var bioinfo = new MGraph.Point(185, nw1, "Bioinformatics");
    var r370a = new MGraph.Point(396, nw1, "NOA370A");
    var r360 = new MGraph.Point(396, nw1 + 30, "NOA360");
    var r370b = new MGraph.Point(481, nw1, "NOA370B");
    var r370c = new MGraph.Point(633, nw1, "NOA370C");

    //44 suite
    var o44b = new MGraph.Point(778, 279, "o44b");
    var o44c = new MGraph.Point(745, 279, "o44c");
    var o44d = new MGraph.Point(670, nw3, "o44d");
    var o44e = new MGraph.Point(o44, 230, "o44e");
    var o44f = new MGraph.Point(o44, 200, "o44f");
    var o44g = new MGraph.Point(o44, 120, "o44g");
    var o44h = new MGraph.Point(o44, 88, "o44h");

    var r44a = new MGraph.Point(o44 + 30, 230, "NOA44A");
    var r44b = new MGraph.Point(778, 309, "NOA44B");
    var r44c = new MGraph.Point(745, 309, "NOA44C");
    var r44d = new MGraph.Point(670, 279, "NOA44D");
    var r44e = new MGraph.Point(o44 - 30, 230, "NOA44E");
    var r44f = new MGraph.Point(o44 - 30, 200, "NOA44F");
    var r44g = new MGraph.Point(o44 - 30, 120, "NOA44G");
    var r44h = new MGraph.Point(o44 - 30, 88, "NOA44H");
    var r44j = new MGraph.Point(o44 + 30, 88, "NOA44J");
    var r44k = new MGraph.Point(o44 + 30, 120, "NOA44K");
    var r44l = new MGraph.Point(o44 + 30, 200, "NOA44L");

    //390suite
    var r390a = new MGraph.Point(464, nw3 - 60, "NOA390A");
    var r380 = new MGraph.Point(378, nw3 - 60, "NOA380");
    var r390c = new MGraph.Point(464, nw3 - 120, "NOA390C");

    //NWHall 2 #e-d
    var o31a2 = new MGraph.Point(198, nw4, "o31a2/250-1");
    var o31a3 = new MGraph.Point(391, nw4, "o31a3/250-2");

    var r2501 = new MGraph.Point(198, nw4 + 60, "r250 - 1");
    var r2502 = new MGraph.Point(391, nw4 + 60, "r250 - 2");

    var r31a2 = new MGraph.Point(198, nw4 - 60, "NOA31A - 2");
    var r31a3 = new MGraph.Point(391, nw4 - 60, "NOA31A - 3");

    var o300 = new MGraph.Point(500, nw4, "o300");

    var o2902 = new MGraph.Point(529, nw4, "290-2/270-1");
    var o2903 = new MGraph.Point(725, nw4, "290-3/270-2");
    var r2901 = new MGraph.Point(555, nw3 + 100, "r290 - 1");
    var r2902 = new MGraph.Point(529, nw4 - 60, "r290 - 2");
    var r2903 = new MGraph.Point(725, nw4 - 60, "r290 - 3");    

    var r2701 = new MGraph.Point(529, nw4 + 60, "r270 - 1");
    var r2702 = new MGraph.Point(725, nw4 + 60, "r270 - 2");

    //NWHall 3 fg
    var o170 = new MGraph.Point(316, nw5, "o170");
    var mens1 = new MGraph.Point(391, nw5, "Mens/ 250-3");
    var o2602 = new MGraph.Point(500, nw5, "o260 - 2");   
    var womens1 = new MGraph.Point(531, nw5, "Womens/270 - 3");
    var o210 = new MGraph.Point(618, nw5, "o210");
    var o220 = new MGraph.Point(692, nw5, "o220");
    var r2503 = new MGraph.Point(391, nw5 - 60, "r250 - 3");
    var mens = new MGraph.Point(391, nw5 + 60, "Mens");
    var womens = new MGraph.Point(531, nw5 + 60, "Womens");
    var r2703 = new MGraph.Point(531, nw5 - 60, "r270 - 3");

    graph.addNodeByValue(elevator);
    graph.addNodesByValue([a, b, c, d, e, f, g, h, i,
                           o2901, o390a, o380a, ocyber, olrc, //nw hall1
                           r380, r390a, r390c, //390 suite
                           cyber, r340a, bioinfo, r370a, r360, r370b, r370c, //LRC Suite
                           vending, o31a, o150, o140, o130, o120, r150, r140, r130, r120, //sw hall
                           o44b, o44c, o44d, o44e, o44f, o44g, o44h, //44 suite
                           r31a, r31a1, r31a2, r31a3, r2501, r2502, r300, r290, r2901, r2902, r2903, //inside horizontal classrooms
                           r250, r260, r270, r2701, r2702, r220, r210, r170, //inside horizontal classrooms
                           o31a2, o31a3, o300, o2902, o2903, //NWLine 4 between e-d
                           o170, mens1, womens1, o210, o220, o2602, //Nw Line 5 f-g
                           r2503, mens, womens, r2703,
                           o30, o40, o50, o60, o80, r30, r40, r50, r60, r80, r90, //ne hall elevator hall
                           r44a, r44b, r44c, r44d, r44e, r44f, r44g, r44h, r44j, r44k, r44l]);
    //elevator hall and adjuct halls
    //inner links
    graph.addUndirectedEdge(elevator, b, MGraph.CalcCostBetweenPoints(elevator, b));
    graph.addUndirectedEdge(a, b, MGraph.CalcCostBetweenPoints(a, b));
    graph.addUndirectedEdge(elevator, d, MGraph.CalcCostBetweenPoints(elevator, d));
    graph.addUndirectedEdge(d, o30, MGraph.CalcCostBetweenPoints(d, o30));
    graph.addUndirectedEdge(o30, o40, MGraph.CalcCostBetweenPoints(o30, o40));
    graph.addUndirectedEdge(o40, f, MGraph.CalcCostBetweenPoints(o40, f));
    graph.addUndirectedEdge(f, o50, MGraph.CalcCostBetweenPoints(f, o50));
    graph.addUndirectedEdge(o50, o60, MGraph.CalcCostBetweenPoints(o50, o60));
    graph.addUndirectedEdge(o60, h, MGraph.CalcCostBetweenPoints(o60, h));
    graph.addUndirectedEdge(h, o80, MGraph.CalcCostBetweenPoints(h, o80));
    //hall links
    graph.addUndirectedEdge(d, e, MGraph.CalcCostBetweenPoints(d, e));
    graph.addUndirectedEdge(f, g, MGraph.CalcCostBetweenPoints(f, g));    
    //outerlinks
    graph.addUndirectedEdge(a, elevator, MGraph.CalcCostBetweenPoints(a, elevator));
    graph.addUndirectedEdge(a, d, MGraph.CalcCostBetweenPoints(a, d));
    graph.addUndirectedEdge(a, o30, MGraph.CalcCostBetweenPoints(a, o30));
    graph.addUndirectedEdge(a, o40, MGraph.CalcCostBetweenPoints(a, o40));
    graph.addUndirectedEdge(a, f, MGraph.CalcCostBetweenPoints(a, f));
    graph.addUndirectedEdge(a, o50, MGraph.CalcCostBetweenPoints(a, o50));
    graph.addUndirectedEdge(a, o60, MGraph.CalcCostBetweenPoints(a, o60));
    graph.addUndirectedEdge(a, h, MGraph.CalcCostBetweenPoints(a, h));

    graph.addUndirectedEdge(b, d, MGraph.CalcCostBetweenPoints(b, d));
    graph.addUndirectedEdge(b, o30, MGraph.CalcCostBetweenPoints(b, o30));
    graph.addUndirectedEdge(b, o40, MGraph.CalcCostBetweenPoints(b, o40));
    graph.addUndirectedEdge(b, f, MGraph.CalcCostBetweenPoints(b, f));
    graph.addUndirectedEdge(b, o50, MGraph.CalcCostBetweenPoints(b, o50));
    graph.addUndirectedEdge(b, o60, MGraph.CalcCostBetweenPoints(b, o60));
    graph.addUndirectedEdge(b, h, MGraph.CalcCostBetweenPoints(b, h));

    graph.addUndirectedEdge(elevator, o30, MGraph.CalcCostBetweenPoints(elevator, o30));
    graph.addUndirectedEdge(elevator, o40, MGraph.CalcCostBetweenPoints(elevator, o40));
    graph.addUndirectedEdge(elevator, f, MGraph.CalcCostBetweenPoints(elevator, f));    
    graph.addUndirectedEdge(elevator, o50, MGraph.CalcCostBetweenPoints(elevator, o50));
    graph.addUndirectedEdge(elevator, o60, MGraph.CalcCostBetweenPoints(elevator, o60));
    graph.addUndirectedEdge(elevator, h, MGraph.CalcCostBetweenPoints(elevator, h));

    graph.addUndirectedEdge(d, o40, MGraph.CalcCostBetweenPoints(d, o40));
    graph.addUndirectedEdge(d, f, MGraph.CalcCostBetweenPoints(d, f));
    graph.addUndirectedEdge(d, o50, MGraph.CalcCostBetweenPoints(d, o50));
    graph.addUndirectedEdge(d, o60, MGraph.CalcCostBetweenPoints(d, o60));
    graph.addUndirectedEdge(d, h, MGraph.CalcCostBetweenPoints(d, h));

    graph.addUndirectedEdge(o30, f, MGraph.CalcCostBetweenPoints(o30, f));
    graph.addUndirectedEdge(o30, o50, MGraph.CalcCostBetweenPoints(o30, o50));
    graph.addUndirectedEdge(o30, o60, MGraph.CalcCostBetweenPoints(o30, o60));
    graph.addUndirectedEdge(o30, h, MGraph.CalcCostBetweenPoints(o30, h));

    graph.addUndirectedEdge(o40, o50, MGraph.CalcCostBetweenPoints(o40, o50));
    graph.addUndirectedEdge(o40, o60, MGraph.CalcCostBetweenPoints(o40, o60));
    graph.addUndirectedEdge(o40, h, MGraph.CalcCostBetweenPoints(o40, h));

    graph.addUndirectedEdge(f, o60, MGraph.CalcCostBetweenPoints(f, o60));
    graph.addUndirectedEdge(f, h, MGraph.CalcCostBetweenPoints(f, h));
    //inroom links.
    graph.addUndirectedEdge(o30, r30, MGraph.CalcCostBetweenPoints(o30, o30));
    graph.addUndirectedEdge(o40, r40, MGraph.CalcCostBetweenPoints(o40, r40));
    graph.addUndirectedEdge(o50, r50, MGraph.CalcCostBetweenPoints(o50, r50));
    graph.addUndirectedEdge(o60, r60, MGraph.CalcCostBetweenPoints(o60, r60));
    graph.addUndirectedEdge(o80, r90, MGraph.CalcCostBetweenPoints(o80, r90));

    //nw hall1 & lrc area
    //inner links
    graph.addUndirectedEdge(b, o44d, MGraph.CalcCostBetweenPoints(b, o44d));
    graph.addUndirectedEdge(o44d, o2901, MGraph.CalcCostBetweenPoints(o44d, o2901));
    graph.addUndirectedEdge(o2901, o390a, MGraph.CalcCostBetweenPoints(o2901, o390a));
    graph.addUndirectedEdge(o390a, ocyber, MGraph.CalcCostBetweenPoints(o390a, ocyber));
    graph.addUndirectedEdge(ocyber, c, MGraph.CalcCostBetweenPoints(ocyber, c));
    graph.addUndirectedEdge(ocyber, olrc, MGraph.CalcCostBetweenPoints(ocyber, olrc));
    //outer links
    graph.addUndirectedEdge(b, o2901, MGraph.CalcCostBetweenPoints(b, o2901));
    graph.addUndirectedEdge(b, o390a, MGraph.CalcCostBetweenPoints(b, o390a));
    graph.addUndirectedEdge(b, o380a, MGraph.CalcCostBetweenPoints(b, o380a));
    graph.addUndirectedEdge(b, ocyber, MGraph.CalcCostBetweenPoints(b, ocyber));

    graph.addUndirectedEdge(c, olrc, MGraph.CalcCostBetweenPoints(c, olrc)); //weird connection but ok.
    graph.addUndirectedEdge(c, o380a, MGraph.CalcCostBetweenPoints(c, o380a));
    graph.addUndirectedEdge(c, o390a, MGraph.CalcCostBetweenPoints(c, o390a));
    graph.addUndirectedEdge(c, o2901, MGraph.CalcCostBetweenPoints(c, o2901));
    graph.addUndirectedEdge(c, o44d, MGraph.CalcCostBetweenPoints(c, o44d));


    //in room links
    graph.addUndirectedEdge(olrc, r340a, MGraph.CalcCostBetweenPoints(olrc, r340a));
    graph.addUndirectedEdge(ocyber, r340a, MGraph.CalcCostBetweenPoints(ocyber, r340a));
    graph.addUndirectedEdge(ocyber, cyber, MGraph.CalcCostBetweenPoints(ocyber, cyber));
    graph.addUndirectedEdge(r340a, bioinfo, MGraph.CalcCostBetweenPoints(r340a, bioinfo));
    graph.addUndirectedEdge(r340a, r370a, MGraph.CalcCostBetweenPoints(r340a, r370a)); //I am going to leave these as verticies indicating there is a door to pass thru..
    graph.addUndirectedEdge(r370a, r360, MGraph.CalcCostBetweenPoints(r340a, r360));
    graph.addUndirectedEdge(r370b, r370c, MGraph.CalcCostBetweenPoints(r370b, r370c));
    
    //44suite
    //inner links
    graph.addUndirectedEdge(a, o44b, MGraph.CalcCostBetweenPoints(a, o44b));
    graph.addUndirectedEdge(o44b, o44c, MGraph.CalcCostBetweenPoints(o44b, o44c));
    graph.addUndirectedEdge(o44c, r44d, MGraph.CalcCostBetweenPoints(o44c, r44d));
    graph.addUndirectedEdge(o44c, o44e, MGraph.CalcCostBetweenPoints(o44c, o44e));
    graph.addUndirectedEdge(o44e, o44f, MGraph.CalcCostBetweenPoints(o44e, o44f));
    graph.addUndirectedEdge(o44f, o44g, MGraph.CalcCostBetweenPoints(o44f, o44g));
    graph.addUndirectedEdge(o44g, o44h, MGraph.CalcCostBetweenPoints(o44g, o44h));
    //outer links
    graph.addUndirectedEdge(a, o44c, MGraph.CalcCostBetweenPoints(a, o44c));
    graph.addUndirectedEdge(o44e, o44g, MGraph.CalcCostBetweenPoints(o44e, o44g));
    graph.addUndirectedEdge(o44e, o44h, MGraph.CalcCostBetweenPoints(o44e, o44h));
    //in room links
    graph.addUndirectedEdge(o44b, r44a, MGraph.CalcCostBetweenPoints(o44b, r44a));
    graph.addUndirectedEdge(o44b, r44b, MGraph.CalcCostBetweenPoints(o44b, r44b));
    graph.addUndirectedEdge(o44c, r44c, MGraph.CalcCostBetweenPoints(o44c, r44c));
    graph.addUndirectedEdge(o44d, r44d, MGraph.CalcCostBetweenPoints(o44d, r44d));
    graph.addUndirectedEdge(o44e, r44e, MGraph.CalcCostBetweenPoints(o44e, r44e));
    graph.addUndirectedEdge(o44f, r44f, MGraph.CalcCostBetweenPoints(o44f, r44f));
    graph.addUndirectedEdge(o44f, r44l, MGraph.CalcCostBetweenPoints(o44f, r44l));
    graph.addUndirectedEdge(o44g, r44g, MGraph.CalcCostBetweenPoints(o44g, r44g));
    graph.addUndirectedEdge(o44g, r44k, MGraph.CalcCostBetweenPoints(o44g, r44k));
    graph.addUndirectedEdge(o44h, r44h, MGraph.CalcCostBetweenPoints(o44h, r44h));
    graph.addUndirectedEdge(o44h, r44j, MGraph.CalcCostBetweenPoints(o44h, r44j));

    //390 suite.    
    graph.addUndirectedEdge(o390a, r390a, MGraph.CalcCostBetweenPoints(o390a, r390a));
    graph.addUndirectedEdge(o380a, r380, MGraph.CalcCostBetweenPoints(o44h, r380));
    graph.addUndirectedEdge(o390a, r390c, MGraph.CalcCostBetweenPoints(o390a, r390c));
    graph.addUndirectedEdge(r390a, r390c, MGraph.CalcCostBetweenPoints(r390a, r390c));

    //swhall
    //inner links
    graph.addUndirectedEdge(c, o31a, MGraph.CalcCostBetweenPoints(c, o31a));
    graph.addUndirectedEdge(o31a, vending, MGraph.CalcCostBetweenPoints(o31a, vending));
    graph.addUndirectedEdge(vending, e, MGraph.CalcCostBetweenPoints(vending, e));
    graph.addUndirectedEdge(e, g, MGraph.CalcCostBetweenPoints(e, g));
    graph.addUndirectedEdge(g, o150, MGraph.CalcCostBetweenPoints(g, o150));
    graph.addUndirectedEdge(o150, o140, MGraph.CalcCostBetweenPoints(o150, o140));
    graph.addUndirectedEdge(o140, o130, MGraph.CalcCostBetweenPoints(o140, o130));
    graph.addUndirectedEdge(o130, o120, MGraph.CalcCostBetweenPoints(o130, o120));
    graph.addUndirectedEdge(o120, i, MGraph.CalcCostBetweenPoints(o120, i));

    //outer links
    graph.addUndirectedEdge(c, vending, MGraph.CalcCostBetweenPoints(c, vending));
    graph.addUndirectedEdge(c, e, MGraph.CalcCostBetweenPoints(c, e));
    graph.addUndirectedEdge(c, g, MGraph.CalcCostBetweenPoints(c, g));
    graph.addUndirectedEdge(c, o150, MGraph.CalcCostBetweenPoints(c, o150));
    graph.addUndirectedEdge(c, o140, MGraph.CalcCostBetweenPoints(c, o140));
    graph.addUndirectedEdge(c, o130, MGraph.CalcCostBetweenPoints(c, o130));
    graph.addUndirectedEdge(c, o120, MGraph.CalcCostBetweenPoints(c, o120));
    graph.addUndirectedEdge(c, i, MGraph.CalcCostBetweenPoints(c, i));

    graph.addUndirectedEdge(e, o150, MGraph.CalcCostBetweenPoints(e, o150));
    graph.addUndirectedEdge(e, o140, MGraph.CalcCostBetweenPoints(e, o140));
    graph.addUndirectedEdge(e, o130, MGraph.CalcCostBetweenPoints(e, o130));
    graph.addUndirectedEdge(e, o120, MGraph.CalcCostBetweenPoints(e, o120));
    graph.addUndirectedEdge(e, i, MGraph.CalcCostBetweenPoints(e, i));

    graph.addUndirectedEdge(g, o140, MGraph.CalcCostBetweenPoints(g, o140));
    graph.addUndirectedEdge(g, o130, MGraph.CalcCostBetweenPoints(g, o130));
    graph.addUndirectedEdge(g, o120, MGraph.CalcCostBetweenPoints(g, o120));
    graph.addUndirectedEdge(g, i, MGraph.CalcCostBetweenPoints(g, i));
    //in rooms
    
    graph.addUndirectedEdge(o150, r150, MGraph.CalcCostBetweenPoints(o150, r150));
    graph.addUndirectedEdge(o140, r140, MGraph.CalcCostBetweenPoints(o140, r140));
    graph.addUndirectedEdge(o130, r130, MGraph.CalcCostBetweenPoints(o130, r130));
    graph.addUndirectedEdge(o120, r120, MGraph.CalcCostBetweenPoints(o120, r120));

    //NWLine 4 between e-d    
    //inner links
    graph.addUndirectedEdge(e, o31a2, MGraph.CalcCostBetweenPoints(e, o31a2));
    graph.addUndirectedEdge(o31a2, o31a3, MGraph.CalcCostBetweenPoints(o31a2, o31a3));
    graph.addUndirectedEdge(o31a3, o300, MGraph.CalcCostBetweenPoints(o31a3, o300));
    graph.addUndirectedEdge(o300, o2902, MGraph.CalcCostBetweenPoints(o300, o2902));
    graph.addUndirectedEdge(o2902, o2903, MGraph.CalcCostBetweenPoints(o2902, o2903));
    graph.addUndirectedEdge(o2903, d, MGraph.CalcCostBetweenPoints(o2903, d));
    //outerlinks
    graph.addUndirectedEdge(e, o31a3, MGraph.CalcCostBetweenPoints(e, o31a3));
    graph.addUndirectedEdge(e, o300, MGraph.CalcCostBetweenPoints(e, o300));
    graph.addUndirectedEdge(e, o2902, MGraph.CalcCostBetweenPoints(e, o2902));
    graph.addUndirectedEdge(e, o2903, MGraph.CalcCostBetweenPoints(e, o2903));

    graph.addUndirectedEdge(d, o31a2, MGraph.CalcCostBetweenPoints(d, o31a2));
    graph.addUndirectedEdge(d, o31a3, MGraph.CalcCostBetweenPoints(d, o31a3));
    graph.addUndirectedEdge(d, o300, MGraph.CalcCostBetweenPoints(d, o300));
    graph.addUndirectedEdge(d, o2902, MGraph.CalcCostBetweenPoints(d, o2902));    

    //inroom    
    //r31a.
    graph.addUndirectedEdge(o31a, r31a1, MGraph.CalcCostBetweenPoints(o31a, r31a1));
    graph.addUndirectedEdge(o31a2, r31a2, MGraph.CalcCostBetweenPoints(o31a2, r31a2));
    graph.addUndirectedEdge(o31a3, r31a3, MGraph.CalcCostBetweenPoints(o31a3, r31a3));
    graph.addUndirectedEdge(r31a1, r31a, MGraph.CalcCostBetweenPoints(r31a1, r31a));
    graph.addUndirectedEdge(r31a2, r31a, MGraph.CalcCostBetweenPoints(r31a2, r31a));
    graph.addUndirectedEdge(r31a3, r31a, MGraph.CalcCostBetweenPoints(r31a3, r31a));
    //noa250
    graph.addUndirectedEdge(o31a2, r2501, MGraph.CalcCostBetweenPoints(o31a2, r2501));
    graph.addUndirectedEdge(o31a3, r2502, MGraph.CalcCostBetweenPoints(o31a3, r2502));
    graph.addUndirectedEdge(r2501, r250, MGraph.CalcCostBetweenPoints(r2501, r250));
    graph.addUndirectedEdge(r2502, r250, MGraph.CalcCostBetweenPoints(r2502, r250));
    //noa300 
    graph.addUndirectedEdge(o300, r300, MGraph.CalcCostBetweenPoints(o300, r300));
    //noa260
    graph.addUndirectedEdge(o300, r260, MGraph.CalcCostBetweenPoints(o300, r260));
    //noa 290
    graph.addUndirectedEdge(o2901, r2901, MGraph.CalcCostBetweenPoints(o2901, r2901));
    graph.addUndirectedEdge(o2902, r2902, MGraph.CalcCostBetweenPoints(o2902, r2902));
    graph.addUndirectedEdge(o2903, r2903, MGraph.CalcCostBetweenPoints(o2903, r2903));
    graph.addUndirectedEdge(r2901, r290, MGraph.CalcCostBetweenPoints(r2901, r290));
    graph.addUndirectedEdge(r2902, r290, MGraph.CalcCostBetweenPoints(r2902, r290));
    graph.addUndirectedEdge(r2903, r290, MGraph.CalcCostBetweenPoints(r2903, r290));

    graph.addUndirectedEdge(o2901, r2701, MGraph.CalcCostBetweenPoints(o2901, r2701));
    graph.addUndirectedEdge(o2902, r2702, MGraph.CalcCostBetweenPoints(o2902, r2702));
    graph.addUndirectedEdge(r2701, r270, MGraph.CalcCostBetweenPoints(r2701, r270));
    graph.addUndirectedEdge(r2702, r270, MGraph.CalcCostBetweenPoints(r2702, r270));

    //NWLine 5 between gf 
    //inner links
    graph.addUndirectedEdge(g, o170, MGraph.CalcCostBetweenPoints(g, o170));
    graph.addUndirectedEdge(o170, mens1, MGraph.CalcCostBetweenPoints(o170, mens1));
    graph.addUndirectedEdge(mens1, o2602, MGraph.CalcCostBetweenPoints(mens1, o2602));
    graph.addUndirectedEdge(o2602, womens1, MGraph.CalcCostBetweenPoints(o2602, womens1));
    graph.addUndirectedEdge(womens1, o210, MGraph.CalcCostBetweenPoints(womens1, o210));
    graph.addUndirectedEdge(o210, o220, MGraph.CalcCostBetweenPoints(o210, o220));
    graph.addUndirectedEdge(o220, f, MGraph.CalcCostBetweenPoints(o220, f));
    //outer links    
    graph.addUndirectedEdge(g, mens1, MGraph.CalcCostBetweenPoints(g, mens1));
    graph.addUndirectedEdge(g, o2602, MGraph.CalcCostBetweenPoints(g, o2602));
    graph.addUndirectedEdge(g, womens1, MGraph.CalcCostBetweenPoints(g, womens1));
    graph.addUndirectedEdge(g, o210, MGraph.CalcCostBetweenPoints(g, o210));
    graph.addUndirectedEdge(g, o220, MGraph.CalcCostBetweenPoints(g, o220));

    graph.addUndirectedEdge(f, o170, MGraph.CalcCostBetweenPoints(f, o170));
    graph.addUndirectedEdge(f, mens1, MGraph.CalcCostBetweenPoints(f, mens1));
    graph.addUndirectedEdge(f, o2602, MGraph.CalcCostBetweenPoints(f, o2602));
    graph.addUndirectedEdge(f, womens1, MGraph.CalcCostBetweenPoints(f, womens1));
    graph.addUndirectedEdge(f, o210, MGraph.CalcCostBetweenPoints(f, o210));
    //in room
    graph.addUndirectedEdge(o170, r170, MGraph.CalcCostBetweenPoints(f, r170));
    graph.addUndirectedEdge(mens1, mens, MGraph.CalcCostBetweenPoints(mens1, mens));
    graph.addUndirectedEdge(mens1, r2503, MGraph.CalcCostBetweenPoints(mens1, r2503));
    graph.addUndirectedEdge(r2503, r250, MGraph.CalcCostBetweenPoints(r2503, r250));
    graph.addUndirectedEdge(womens1, womens, MGraph.CalcCostBetweenPoints(womens1, womens));
    graph.addUndirectedEdge(womens1, r2703, MGraph.CalcCostBetweenPoints(womens1, r2703));
    graph.addUndirectedEdge(r2703, r270, MGraph.CalcCostBetweenPoints(r2703, r270));
    graph.addUndirectedEdge(o210, r210, MGraph.CalcCostBetweenPoints(o210, r210));
    graph.addUndirectedEdge(o220, r220, MGraph.CalcCostBetweenPoints(o220, r220));
    return graph;
}

MapPoints.GetBasement = function () {
    var graph = new MGraph.Graph();
    graph.label = "Basement";

    var swhall1 = 80; //to uh
    var swhall2 = 605; //main hall

    var nwhall = 573;
    //outer poiunts
    

    var elevator = new MGraph.Point(815, 783, "Elevator");
    var a = new MGraph.Point(815, swhall2, "A");
    var b = new MGraph.Point(nwhall, swhall2, "B");
    var omens = new MGraph.Point(509, swhall2, "omens");
    var onob180 = new MGraph.Point(519, swhall2, "ONOB180");
    var owomens = new MGraph.Point(398, swhall2, "owomens");
    var onob150 = new MGraph.Point(253, swhall2, "onob150");
    var c = new MGraph.Point(126, swhall2, "c");
    var sstairs = new MGraph.Point(126, 728, "south stair well");
    var onob12a = new MGraph.Point(nwhall, 447, "onob12a");
    var onob040 = new MGraph.Point(nwhall, 404, "onob040");
    var onob110 = new MGraph.Point(nwhall, 340, "onob110");
    var onob050 = new MGraph.Point(nwhall, 335, "onob050");
    var onob06a = new MGraph.Point(nwhall, 258, "onob060a");
    var onob100 = new MGraph.Point(nwhall, 253, "onob100");
    var d = new MGraph.Point(nwhall, swhall1, "d");
    var onob090 = new MGraph.Point(457, swhall1, "onob080");
    var onob080 = new MGraph.Point(403, swhall1, "onob090");
    //inner points
    var rnob180 = new MGraph.Point(519, swhall2 + 50, "NOB180");
    var rnob150 = new MGraph.Point(253, swhall2 - 50, "NOB150");
    var rnob12a = new MGraph.Point(nwhall - 70, 447, "NOB12A");
    var rnob12b = new MGraph.Point(356, 410, "NOB12B");
    var rnob040 = new MGraph.Point(nwhall + 70, 404, "NOB040");
    var rnob050 = new MGraph.Point(nwhall + 70, 335, "NOB050");
    var rnob110 = new MGraph.Point(nwhall - 70, 340, "NOB110");
    var rnob100 = new MGraph.Point(nwhall - 70, 253, "NOB100");
    var rnob06a = new MGraph.Point(nwhall + 70, 258, "NOB06A");
    var onob06b = new MGraph.Point(783, 258, "oNOB06B");
    var rnob06b = new MGraph.Point(783, 308, "NOB06B");
    var rnob090 = new MGraph.Point(457, swhall1 + 70, "NOB090");
    var rnob080 = new MGraph.Point(403, swhall1 + 70, "NOB080");

    graph.addNodeByValue(elevator);
    graph.addNodesByValue([a, b, c, d, omens, owomens, sstairs,
                            onob180, onob150, onob12a, onob040, onob110, onob050, onob06a, onob06b, onob100, onob090, onob080,
                            rnob180, rnob150, rnob12a, rnob12b, rnob040, rnob110, rnob050, rnob06a, rnob06b, rnob100, rnob090, rnob080]);

    //inner hall links
    //main hall - sw 
    graph.addUndirectedEdge(elevator, a, MGraph.CalcCostBetweenPoints(elevator, a));
    graph.addUndirectedEdge(a, b, MGraph.CalcCostBetweenPoints(a, b));
    graph.addUndirectedEdge(b, onob180, MGraph.CalcCostBetweenPoints(b, onob180));
    graph.addUndirectedEdge(onob180, omens, MGraph.CalcCostBetweenPoints(onob180, omens));
    graph.addUndirectedEdge(omens, owomens, MGraph.CalcCostBetweenPoints(omens, owomens));
    graph.addUndirectedEdge(owomens, onob150, MGraph.CalcCostBetweenPoints(owomens, onob150));
    graph.addUndirectedEdge(onob150, c, MGraph.CalcCostBetweenPoints(onob150, c));
    graph.addUndirectedEdge(c, sstairs, MGraph.CalcCostBetweenPoints(c, sstairs));
    //nw hall
    graph.addUndirectedEdge(b, onob12a, MGraph.CalcCostBetweenPoints(b, onob12a));
    graph.addUndirectedEdge(onob12a, onob040, MGraph.CalcCostBetweenPoints(onob12a, onob040));
    graph.addUndirectedEdge(onob040, onob110, MGraph.CalcCostBetweenPoints(onob110, onob040));
    graph.addUndirectedEdge(onob110, onob050, MGraph.CalcCostBetweenPoints(onob110, onob050));
    graph.addUndirectedEdge(onob050, onob06a, MGraph.CalcCostBetweenPoints(onob050, onob06a));
    graph.addUndirectedEdge(onob06a, onob100, MGraph.CalcCostBetweenPoints(onob06a, onob100));
    graph.addUndirectedEdge(onob100, d, MGraph.CalcCostBetweenPoints(onob100, d));
    //swhall 1 to uh
    graph.addUndirectedEdge(d, onob080, MGraph.CalcCostBetweenPoints(d, onob080));
    graph.addUndirectedEdge(onob080, onob090, MGraph.CalcCostBetweenPoints(onob080, onob090));
    //outer hall links
    //A -> SWhall2
    graph.addUndirectedEdge(a, onob180, MGraph.CalcCostBetweenPoints(a, onob180));
    graph.addUndirectedEdge(a, omens, MGraph.CalcCostBetweenPoints(a, omens));
    graph.addUndirectedEdge(a, owomens, MGraph.CalcCostBetweenPoints(a, owomens));
    graph.addUndirectedEdge(a, onob150, MGraph.CalcCostBetweenPoints(a, onob150));
    graph.addUndirectedEdge(a, c, MGraph.CalcCostBetweenPoints(a, c));
    //B -> SWHall2
    graph.addUndirectedEdge(b, omens, MGraph.CalcCostBetweenPoints(b, omens));
    graph.addUndirectedEdge(b, owomens, MGraph.CalcCostBetweenPoints(b, owomens));
    graph.addUndirectedEdge(b, onob150, MGraph.CalcCostBetweenPoints(b, onob150));
    graph.addUndirectedEdge(b, c, MGraph.CalcCostBetweenPoints(b, c));
    //NWHALL
    graph.addUndirectedEdge(b, onob040, MGraph.CalcCostBetweenPoints(b, onob040));
    graph.addUndirectedEdge(b, onob110, MGraph.CalcCostBetweenPoints(b, onob110));
    graph.addUndirectedEdge(b, onob050, MGraph.CalcCostBetweenPoints(b, onob050));
    graph.addUndirectedEdge(b, onob06a, MGraph.CalcCostBetweenPoints(b, onob06a));
    graph.addUndirectedEdge(b, onob100, MGraph.CalcCostBetweenPoints(b, onob100));
    graph.addUndirectedEdge(b, d, MGraph.CalcCostBetweenPoints(b, d));
    //SWhall1 
    graph.addUndirectedEdge(d, onob090, MGraph.CalcCostBetweenPoints(d, onob090));

    //inner room links.
    graph.addUndirectedEdge(onob180, rnob180, MGraph.CalcCostBetweenPoints(onob180, rnob180));
    graph.addUndirectedEdge(onob150, rnob150, MGraph.CalcCostBetweenPoints(onob150, rnob150));
    graph.addUndirectedEdge(onob12a, rnob12a, MGraph.CalcCostBetweenPoints(onob12a, rnob12a));
    graph.addUndirectedEdge(rnob12a, rnob12b, MGraph.CalcCostBetweenPoints(rnob12a, rnob12b));
    graph.addUndirectedEdge(onob040, rnob040, MGraph.CalcCostBetweenPoints(onob040, rnob040));
    graph.addUndirectedEdge(onob110, rnob110, MGraph.CalcCostBetweenPoints(onob110, rnob110));
    graph.addUndirectedEdge(onob050, rnob050, MGraph.CalcCostBetweenPoints(onob050, rnob050));
    graph.addUndirectedEdge(onob100, rnob100, MGraph.CalcCostBetweenPoints(onob100, rnob100));
    graph.addUndirectedEdge(onob090, rnob090, MGraph.CalcCostBetweenPoints(onob090, rnob090));
    graph.addUndirectedEdge(onob080, rnob080, MGraph.CalcCostBetweenPoints(onob080, rnob080));
    graph.addUndirectedEdge(onob06a, rnob06a, MGraph.CalcCostBetweenPoints(onob06a, rnob06a));
    graph.addUndirectedEdge(rnob06a, onob06b, MGraph.CalcCostBetweenPoints(rnob06a, onob06b));
    graph.addUndirectedEdge(onob06b, rnob06b, MGraph.CalcCostBetweenPoints(onob06b, rnob06b));

    return graph;
}

//Returns the shortest path between string source and string destination.
MapPoints.GetPath = function (graph, source, destination) {
    var shortestPathTo = false;
    var sourcept = graph.getNodeByName(source); //covert our strings into nods.
    var destpt = graph.getNodeByName(destination);
    if (sourcept && destpt) {
        var spanningtree = MGraph.Dijkstra(graph, sourcept); //Get the spanning tree
        shortestPathTo = MGraph.ShortestPath(spanningtree, sourcept, destpt); //get the shortest path to the destination.
    }
    return shortestPathTo;
}