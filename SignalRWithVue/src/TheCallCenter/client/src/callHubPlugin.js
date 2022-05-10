import CallHub from ".callHub";

export default {
    install(vue, options) {
        CallHub.start();
        vue.prototype.$callhub = CallHub;
    }
};
