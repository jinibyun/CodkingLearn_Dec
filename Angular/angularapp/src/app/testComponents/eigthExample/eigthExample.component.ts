import { Component, OnInit } from '@angular/core';
import { PostService } from '../../services/post.service';
import { Post } from '../../models/Post';

@Component({
  selector: 'app-eigthExample',
  templateUrl: './eigthExample.component.html',
  styleUrls: ['./eigthExample.component.css']
})
export class EigthExampleComponent implements OnInit {
  posts: Post[];
  
  currentPost: Post = {
    id:0,
    title : '',
    body: ''
  };

  isEdit:boolean = false;

  constructor(private postService: PostService) { }

  ngOnInit() {  
    this.postService.getPosts().subscribe(posts => {
      // console.log(posts);
      this.posts = posts;
    });
  }

  onNewPost(post: Post){
    this.posts.unshift(post);
  }

  editPost(post:Post){
      this.currentPost = post;
      this.isEdit = true;
  }

  onUpdatedPost(post: Post){
    this.posts.forEach( (cur, index) =>{
      if(post.id === cur.id){
          this.posts.splice(index, 1);
          this.posts.unshift(post);
          this.isEdit = false;
          //clean
          this.currentPost ={
            id: 0,
            title : '',
            body: ''
          }
      }
    })
  };

  removePost(post: Post){
    if(confirm('Are you sure?')){
      this.postService.removePost(post.id).subscribe(() => {
        this.posts.forEach( (cur, index) =>{
          if(post.id === cur.id){
              this.posts.splice(index, 1);            
          }
        })
      });
    }
  }
}