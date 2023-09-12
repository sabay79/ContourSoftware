<template>
    <div class="notes-list">
        <h3>To Do List</h3>
        <ul v-for="note in notes" :key="note.id"> 
            <li>{{note.description}}</li>
        </ul>
    </div>
</template>

<script>
    export default{
        name : "notes-list", 
        props: {
            notes: Array
        }
    }
</script>

<style scoped>
li{
    list-style-type: none;
}

ul{
    padding-left: 0;
}
</style>