/*
    Dijkstras algoritm for finding the cheapest path.
    By Ben Margevicius
*/

var MGraph = MGraph || {}; //namespace. 

MGraph.Dijkstra = function (Graph, Source) {   
    var spanningtree = [];
    var nodes = Graph.nodes();
    var q = new PriorityQueue({low: true}); //sort by lowest priority first.
    //var q = [];
    //initilize our spanningtree.
    for (var i = 0; i <= nodes.length - 1; i++) {
        var row = new Row(nodes[i].value, Number.POSITIVE_INFINITY, undefined); //Note for spanningtree search
        if (nodes[i].value === Source.value) { //if we are at the source node.            
            row = new Row(nodes[i].value, 0, undefined); //change the default cost from inf to 0 for the source. 
            q.push(nodes[i].value, 0); //assign a higher priority than the rest of the q.
        }        
        else {
            q.push(nodes[i].value, Number.POSITIVE_INFINITY);
        }
        spanningtree.push(row);
    }   
    
    //now find the minimum spanning tree.
    //while (q.size() != 0) { //this causes some weirdness, it'll make the browser freeze and memory usage go up.. I can't evaluate the size of the queue
    for (var k = 0; k <= nodes.length - 1; k++) {        
        var nodevalue = q.pop(); //Get the next node
        var node = Graph.getNode(nodevalue);
        //console.error("Looking at", node.value.name);
        var tablecost = 0;
        spanningtree.forEach(function(row) {
             if(row.value === node.value)
             {               
                tablecost = row.cost;
             }
        });

        for (var n = 0; n <= node.neighbors.length - 1; n++) { //go
            var neighbor = node.neighbors[n];
            var cost = node.costs[n];

            //console.warn("evaluating neighbor", neighbor.value.name, cost);

            for (var i = 0; i <= spanningtree.length - 1; i++) { //go thru our lookup
                var row = spanningtree[i];
                if (row.value.name === neighbor.value.name) { //get the row that matches the neighbor.
                    if (tablecost + cost < row.cost) {
                        //console.log("updating rowcosts");
                        row.cost = tablecost + cost;
                        row.path = node.value.name;
                        q.update(neighbor.value, row.cost);
                    }
                }
            }

        }  //neghbor eval done.
        //PrintTable(spanningtree);
        //q.debug();
    }
    return spanningtree;
}

//Get the shortest path by travaersing backwards from destination to the source.
//Returns an array of points in reverse order.
MGraph.ShortestPath = function (tree, source, destination) {
    shortestpath = [];
    var next = destination.value.name; //starting from the destination
    if (typeof next === "undefined") {
        console.error("I couldn't find the next step in the path. Check to ensure there is a edge between the source and destination.");
        return false;
    }

    while (next != source.value.name) { //keep going until we hit the source node.
        var i = tree.length;            //cache the tree length
        while (i--) {                   //traverse the tree (an array of rows)
            var row = tree[i];
            if (row.value.name == next) {
                if (contains(shortestpath, row.value)) {
                    console.error("Black hole condition happening, I will be stuck in a loop because I am trying to add a cyclic shortest path, also check path weights so they aren't 0", shortestpath);
                    return false;
                }
                shortestpath.push(row.value);
                next = row.path;
                break;  //stop looping for the next node as we have found it.
            }
            if (i <= 0) {
                console.error("I couldn't find the next step in the path. Check to ensure there is a edge between the source and destination.");
                return false;
            }
        }
    }
    shortestpath.push(source.value); //push the source element
    return shortestpath;
}

function contains(array, object) {
    var i = array.length;
    while (i--) {
        if (array[i] === object) {
            return true;
        }
    }
    return false;
}

//our tracking table row, basically an array of rows is a table...
function Row(value, cost, path)
{
    this.path = path;
    this.cost = cost;  //total cost traveled.
    this.value = value;
}

function PrintTable(table) {
    table.forEach(function (row) {
        console.log(row.value.name, row.cost, row.path);
    });
}



/* Not Mine */
/* Thanks to: https://github.com/STRd6/PriorityQueue.js */

(function () {
    /**
    * @private
    */
    var prioritySortLow = function (a, b) {
        return b.priority - a.priority;
    };

    /**
    * @private
    */
    var prioritySortHigh = function (a, b) {
        return a.priority - b.priority;
    };

    /*global PriorityQueue */
    /**
    * @constructor
    * @class PriorityQueue manages a queue of elements with priorities. Default
    * is highest priority first.
    *
    * @param [options] If low is set to true returns lowest first.
    */
    PriorityQueue = function (options) {
        var contents = [];

        var sorted = false;
        var sortStyle;

        if (options && options.low) {
            sortStyle = prioritySortLow;
        } else {
            sortStyle = prioritySortHigh;
        }

        /**
        * @private
        */
        var sort = function () {
            contents.sort(sortStyle);
            sorted = true;
        };

        var self = {
            /**
            * Removes and returns the next element in the queue.
            * @member PriorityQueue
            * @return The next element in the queue. If the queue is empty returns
            * undefined.
            *
            * @see PrioirtyQueue#top
            */
            pop: function () {
                if (!sorted) {
                    sort();
                }

                var element = contents.pop();

                if (element) {
                    return element.object;
                } else {
                    return undefined;
                }
            },

            /**
            * Returns but does not remove the next element in the queue.
            * @member PriorityQueue
            * @return The next element in the queue. If the queue is empty returns
            * undefined.
            *
            * @see PriorityQueue#pop
            */
            top: function () {
                if (!sorted) {
                    sort();
                }

                var element = contents[contents.length - 1];

                if (element) {
                    return element.object;
                } else {
                    return undefined;
                }
            },

            /**
            * @member PriorityQueue
            * @param object The object to check the queue for.
            * @returns true if the object is in the queue, false otherwise.
            */
            includes: function (object) {
                for (var i = contents.length - 1; i >= 0; i--) {
                    if (contents[i].object === object) {
                        return true;
                    }
                }

                return false;
            },

            /**
            * @member PriorityQueue
            * @returns the current number of elements in the queue.
            */
            size: function () {
                return contents.length;
            },

            /**
            * @member PriorityQueue
            * @returns true if the queue is empty, false otherwise.
            */
            empty: function () {
                return contents.length === 0;
            },

            /**
            * @member PriorityQueue
            * @param object The object to be pushed onto the queue.
            * @param priority The priority of the object.
            */
            push: function (object, priority) {
                contents.push({ object: object, priority: priority });
                sorted = false;
            },

            /**
            *
            *
            *
            ***/
            update: function(object, priority) {
                for (var i = contents.length - 1; i >= 0; i--) {
                    if (contents[i].object === object) {
                        contents[i].priority = priority;
                        sort();
                    }
                }
            },
            /*
            */
            debug: function()
            {
                contents.forEach(function(i) {
                    console.log("q", i.object, i.priority);
                });
            }           
        
        };

        return self;
    };
})();