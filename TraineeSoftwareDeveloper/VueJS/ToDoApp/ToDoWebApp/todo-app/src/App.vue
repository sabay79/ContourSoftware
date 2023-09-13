<template>
  <div id="app" class="small-container">
    <h1>Notes</h1>

    <note-form />
    <notes-list v-bind:notes="notes" />
  </div>
</template>


<script>
  import NotesList from './components/NotesList.vue';
  import NoteForm from './components/NoteForm.vue';

  export default {
    name: 'app',
    components: {
      NotesList,
      NoteForm
    },
    data()
    {
      return{
        notes: [
          { id: 1, description: 'Note 1' },
          { id: 2, description: 'Note 2' },
          { id: 3, description: 'Note 3' },
        ]
      }
    }
  }
</script>

<style>
  #app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    color: #2c3e50;
    margin-top: 60px;
  }

  .small-container {
      max-width: 680px;
  }
</style>
