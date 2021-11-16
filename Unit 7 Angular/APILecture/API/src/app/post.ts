export interface Post {
    title: string;
    author: string;
    content: string;
    date: string;
    tags: string[];
}

export interface BlogResult {
    title: string;
    language: string;
    posts: Post[];
}

