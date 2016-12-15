/* Graph Library V0.23
By: Ben Margevicius.
0.2 Added Namespace for clarityn
0.21 Added GetNodeByName
0.22 Added addNodesByValue
0.23 Changed some loops to while-- for perfomance
0.24 Added label property to graph.
*/
var MGraph = MGraph || {}; //namespace. 

MGraph.Point = function (x, y, name) {
    this.name = name|| "";
    this.x = x;
    this.y = y;    
}

MGraph.CalcCostBetweenVertices = function (x2, x1, y2, y1) {
    return Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2)); //distance formula.
}
MGraph.CalcCostBetweenPoints = function (PointA, PointB) {
    return MGraph.CalcCostBetweenVertices(PointA.x, PointB.x, PointA.y, PointB.y);
}

MGraph.Graph = function (label) {
    var nodelist = new MGraph.NodeList();
    var _label = label || ""; //just a label for the graph.
    this.label = function (label) {
        if (label) {
            _label = label;
        }
        else {
            return _label;
        }
    }

    this.addNode = function (Node) {
        try { nodelist.add(Node); }
        catch (err) { alert("Failed to add node. " + err); }

    }
    this.addNodeByValue = function (Value) {
        try { this.addNode(new MGraph.Node(Value)); }
        catch (err) { alert("Failed to add node. " + err); }
    }
    this.addNodesByValue = function (ArrayOfValues) {
        var i = ArrayOfValues.length;
        while (i--) {
            try { this.addNode(new MGraph.Node(ArrayOfValues[i])); }
            catch (err) { alert("Failed to add node. " + err); }
        }
    }

    this.addDirectedEdge = function (From, To, Cost) {
        if (From === To) {
            alert("From == To");
            return false;
        }
        var f = nodelist.findByValue(From);
        var t = nodelist.findByValue(To);

        if (f && t) {
            f.addNeighbor(t);
            f.addCost(Cost);
        }
    }

    this.addUndirectedEdge = function (From, To, Cost) {
        if (From === To) {
            alert("From == To");
            return false;
        }

        var f = nodelist.findByValue(From);
        var t = nodelist.findByValue(To);

        if (f && t) {
            f.addNeighbor(t);
            f.addCost(Cost);
            t.addNeighbor(f);
            t.addCost(Cost);
        }
    }


    this.contains = function (Value) {
        return nodelist.findByValue(Value);
    }
    this.getNode = function (Value) {
        var node = nodelist.findByValue(Value);
        if (!node) throw "Can not find node of value: " + Value;
        return node;
    }

    this.getNodeByName = function (Name) {
        var nodes = nodelist.nodes();
        var i = nodes.length;
        while (i--) {
            if (nodes[i].value.name === Name) {
                return nodes[i];
            }
        }
        return false;
    }

    this.remove = function (Node) {
        try {
            this.removeEdges(Node); //remove the edges for this node
            nodelist.remove(Node);  //then remove the node itself.
        }
        catch (err) {
            alert("Failed to remove node. " + err);
        }
    }

    this.removeEdges = function (Node) {
        console.log("Attempting to remove", Node);
        var index = -1;
        nodelist.nodes().forEach(function (n) { //go thru each node.   
            console.warn("Starting", n.value);

            for (var i = 0; i <= n.neighbors.length - 1; i++) {
                console.log("Neighbor at", n.neighbors[i].value);
                if (n.neighbors[i].value == Node) {
                    index = i;
                    console.log("found at", index);
                }
            }
            if (index != -1) {
                console.error("Removing at", index);
                n.neighbors.splice(index, 1);
                n.costs.splice(index, 1);
                index = -1;
                console.log("node after removal", n);
            }
        });
    }
    this.count = function () { return nodelist.length - 1; }
    this.nodes = function () { return nodelist.nodes(); }
    //this.origin = function () { return nodelist.findByValue()); }
}

MGraph.Node = function (value, neighbors, costs) {
    this.neighbors = []
    this.costs = [];
       
    this.value = value || "";
    this.addNeighbor = function (Neighbor) { this.neighbors.push(Neighbor);  }
    this.addCost = function (Cost) {
        if (!Cost) Cost = -1; //If the graph is unweighted assign a default weight of -1
        this.costs.push(Cost); }
}

MGraph.NodeList = function () {
    var nodes = [];

    this.add = function (Node) {
        if (!this.findByValue(Node.value)) {
            nodes.push(Node);
        }
        else {
            throw "Cannot add nodes of same value: " + Node.value;
        }
    }
    this.remove = function (Node) {
        var index = -1;
        var i = nodes.length;
        while (i--) {
            if (nodes[i].value == Node) {
                index = i;
            }
        }        
        if (index != -1) {
            nodes.splice(index, 1);
            console.error("Removed node", Node);
        }
        else {
            throw "Cannot delete node because it doesn't exist in the node list. " + Node.value;
        }
    }

    this.findByValue = function (Value) {
        var i = nodes.length;
        while (i--) {
            if (nodes[i].value == Value)
                return nodes[i]; //return the matching node. 
        }
        return false;
    }
    this.nodes = function () { return nodes; }
}