<template>
    <div class="note-form">
        <form @submit.prevent="handleSubmit">
            <label for="Description">Note</label>
            <input v-model="note.description" type="text" id="Description" />

            <button>Add Note</button>
        </form>
    </div>
</template>

<script>
    export default {
        name : 'note-form',
        data()
        {
            return{
                note : { description : '', },
            }
        },
        methods:{
            handleSubmit(){
                this.$emit('add:note', this.note);
                console.log('testing handleSubmit');
            },
        },
    }
</script>

<style scoped>
    form{
        margin-bottom: 2rem;
    }
</style>
