# AR Scavenger Hunt

This document serves as both the README for this project and the report. A recent build is included in the `Build/` folder where as screenshots and a video are included in the `Showcase/` folder. The project website is https://github.com/rbuxton1/ar-hunt.

## Overall Objective

The overall objective of this project was to create a modular system in which users could create augmented reality scavenger hunts. The idea would be that one person would hide image trackers for specific items and the other person would then look for the trackers with their phone. When found the user would get to see a special model and them finding the tracker would be recorded. When all trackers are found the game is over.

## Technical Highlights

Because there was not a system included in Vuforia to tell if an object is currently being tracked, I created a system that lets me be able to tell if an object is visible to the user or not. This script could be useful in multitudes of situations, like to help with culling. If we had a relatively complex Update function that only needed to be called when the object is being tracked, we could monitor its tracking status and do such to improve the performance of the app when the object is not tracked.

I also included a dynamic system that allows a developer to quickly add new targets to the ones recognized. This means that a large amount of trackers could be added easily so that the users can use images that relate to their models.

## Differentiating Factors

Personally, I have never seen an AR scavenger hunt in the commercial world so I think that the whole idea is relatively virgin ground. I worked on a different version of an AR scavenger hunt through my work, but that version was done in the web using AR.js and we more geared to providing a tour for its users as it was developed for a museum. I think that the concept should be explored more to see where else this type of interaction could be useful.

## Success?

For software I typically measure success by how complex the code is, and by that standard I think that this project went extraordinarily well. I was originally going to write a much more complex `Manager` script, where it would load all of the assets via a JSON. I have done this before for a different project, but when I decided to cut it out and instead make all the image targets be children of the manager I saved an incredible amount of time.

Another metric that I think is important is modularity, and I think that I also kept the code relatively modular. The JSON approach would have made the code exponentially more modular as the JSON could be served over the web, negating the need to update the app in order to add more assets. Ultimately, I think that the tradeoff of modularity for simplicity made sense in this project as I do not think that my code is something someone will use for a jumping off point in the future.

## With More Time?

I think if I had more time I would have absolutely done the JSON approach. What was making it difficult for me to do so was the fact that from what I could tell Vuforia will not let you change the image the tracker is looking for at runtime without having to jump through a million hoops before it would let you. This would have spiked the amount of time the project would have taken and would make it more complex as a result.

Another thing that I would absolutely love to add if I had the time would be a better UI. I went basic with just text because I do not have many art skills and the ones that I do have are not conducive to UI work. With more time (and no finals) though, I have several friends in the digital design pathway so I would have asked them to work with me on the project.

## Next Time?

I think as always the lesson is that things tend to take longer than you expect. I would have loved to have spent more time on the JSON system so that users could load new JSONs over the web without having to update their apps.

I also think that I would have spent a little more time on design, while the project works as intended, I think that it would have been better if it had more polish on it. While the primitive shapes, colors, and UI have a certain bespoke quality to them I think it would have been nice to add a little more for the eyes.
