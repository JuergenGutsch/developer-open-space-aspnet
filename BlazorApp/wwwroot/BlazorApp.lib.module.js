export function beforeStart(option, extension){
    console.log('beforeStart');
}

export function afterStarted(blazor){
    console.log('afterStarted');

    let containerElement = document.getElementById("container");
    blazor.rootComponents.add(containerElement, 'mycomponent', {});
}