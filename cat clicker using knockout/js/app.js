    var initialCats =  [
    {
        'clickCount' : 0,
        'name' : '*Persian Cat*',
        'imgsrc' : 'img/cat1.jpg',
        'catnames': ['Persian','Ragdoll','American Curl']
    },
    {
        'clickCount' : 0,
        'name' : '*Ragdoll*',
        'imgsrc' : 'img/cat2.jpg',
        'catnames': ['doll']
    },
    {
        'clickCount' : 0,
        'name' : '*Bengal Cat*',
        'imgsrc' : 'img/cat3.jpg',
        'catnames': ['bengaaaal']
    },
    {
        'clickCount' : 0,
        'name' : '*American Curl*',
        'imgsrc' : 'img/cat4.jpg',
        'catnames': ['Americaaaaaaa']

    },
    {
        'clickCount' : 0,
        'name' : '*Japanese Bobtail*',
        'imgsrc' : 'img/cat5.jpg',
        'catnames': ['japaaannnnnnnnn']
    },
    {
        'clickCount' : 0,
        'name' : '*Munchkin cat*',
        'imgsrc' : 'img/cat6.jpg',
        'catnames': ['munchiiii']

    },
    {
        'clickCount' : 0,
        'name' : '*Ragamuffin cat*',
        'imgsrc' : 'img/cat7.jpg',
        'catnames': ['muffiinnn']
    }
    ]

    var Cat =function(data)
    {
        this.message=ko.observable('Number of clicks:');
        this.clickCount = ko.observable(data.clickCount);
        this.name = ko.observable(data.name);
        this.imgsrc = ko.observable(data.imgsrc);
        this.catnames=ko.observableArray(data.catnames);


        this.title = ko.computed(function() {
            var title;
            var clicks =this.clickCount();
            if(clicks==0){title='"still cat is under process"'}
                else if(clicks<10) {title='"Newborn"';}
            else if(clicks<20){title='"Infant"';}
            else if(clicks<30){title='"Adult"';}
            else if(clicks==30){title='"No more clicks please,, cat already died"';}
            else{
                this.currentCat().clickCount()==0;
            }
            return title;
        },this);
    }
    var ViewModel=function()
    {
        var self = this;


        this.catList = ko.observableArray([]);

        this.catname=ko.observable("");


        self.addnickname = function() {
            if(self.catname()!="")
         self.currentCat().catnames.push(self.catname());
         self.catname("");
     };

     self.removeitem = function(item) {
      self.currentCat().catnames.remove(item);
  };



  initialCats.forEach(function(catItem){
    self.catList.push(new Cat(catItem) );
});

  this.currentCat = ko.observable(this.catList()[0]);

  this.incrementCounter = function()
  {
    self.currentCat().clickCount(self.currentCat().clickCount()+1);

};


this.setCat= function(clickedCat)
{
    self.currentCat(clickedCat);
}


}
ko.applyBindings(new ViewModel());